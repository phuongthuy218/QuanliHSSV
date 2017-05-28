 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using quanlyhocsinhgiaovien.BusinessLogicLayer;
using quanlyhocsinhgiaovien.ValueObject;
namespace quanlyhocsinhgiaovien.DataAccessLayer
{
    class Dao
    {
        public static DataTable Getlistgiaovien()
        {
            return DataProvider.GetData("select*from giaovien");
        }
        public static int InsertProfile(giaovien gv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma ",gv.magv ), 
                new SqlParameter("@ten",gv.tengv),
                new SqlParameter("@ns", gv.ngaysinh ),
                new SqlParameter("@gt", gv.gioitinh),
                new SqlParameter("@dt", gv.dantoc),
                new SqlParameter("@tg",gv.tongiao),
                new SqlParameter("@que ",gv.quequan ), 
                new SqlParameter("@td",gv.trinhdo), 
                new SqlParameter("@ngay", gv.ngayvaolam ),
                new SqlParameter("@nn",gv.ngoaingu),
                new SqlParameter("@ghichu", gv.ghichu), 
                new SqlParameter("@tb", gv.tenban),
               
            };
            return DataProvider.ExecuteNonQuery("themhsgiaovien ", para);
        }
        public static int UpdateProfile(giaovien gv)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter ("@ma",gv.magv),
                new SqlParameter ("@ten",gv.tengv),
                new SqlParameter ("@td",gv.trinhdo),
                new SqlParameter("@ns",gv.ngaysinh )
            };
            return DataProvider.ExecuteNonQuery("suathongtingiaovien", para);
        }
        public static int DeleteProfile(giaovien gv)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@ma",gv.magv),
                
                   
            };
            return DataProvider.ExecuteNonQuery("xoathongtingiaovien", para);
        }


        internal static DataTable Timkiemgv(string magv)
        {
            return DataProvider.GetData("select * from giaovien " + magv);
        }
        // ban bo mon 
        public static DataTable Getlistphongban()
        {
            return DataProvider.GetData("select*from banbomon");
        }
        public static int InsertProfile(phongban bm)
        {
            SqlParameter[] para = new SqlParameter[]
            { 
                  
                new SqlParameter("@ten",bm.tenban),
                new SqlParameter("@tb",bm.truongban),
                new SqlParameter("@sogv",bm.sogvdg )  
            };
            return DataProvider.ExecuteNonQuery("themphongban", para);
        }

        internal static int UpdateProfile(phongban bm)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                   
                new SqlParameter("@ten",bm.tenban),
                new SqlParameter("@tb ",bm.truongban),
                new SqlParameter("@sogv",bm.sogvdg )
                
                
            };
            return DataProvider.ExecuteNonQuery("suaphongban", para);
        }

        internal static int DeleteProfile(phongban bm)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ten",bm.tenban) ,
        };
            return DataProvider.ExecuteNonQuery("xoaphongban", para);
        }

        internal static DataTable Timkiembm(string ten)
        {
            return DataProvider.GetData("select * from banbomon " + ten);
        }
        
        /// // lịc h dạy thay 
         
        public static DataTable Getlistlichdaythay()
        {
            return DataProvider.GetData("select*from lichdaythay");
        }
        public static int InsertProfile(daythay dt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@thu", dt.thu ), 
                new SqlParameter("@tuan",dt.tuan),
                new SqlParameter("@buoi",dt.buoi),
                new SqlParameter("@tiet",dt.tiet),
                new SqlParameter("@lop",dt.lop),
                new SqlParameter("@gvn",dt.magiaoviennghi),
                new SqlParameter("@gvd",dt.magiaoviendaythay)
                 
               
            };
            return DataProvider.ExecuteNonQuery("themlichdaythay ", para);
        }
        public static int UpdateProfile(daythay dt)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@tiet",dt.tiet),
                new SqlParameter("@lop",dt.lop),
                new SqlParameter("@gvn",dt.magiaoviennghi),
                new SqlParameter("@gvd",dt.magiaoviendaythay)
                 
            };
            return DataProvider.ExecuteNonQuery("sualichdaythay", para);
        }
        internal static int DeleteProfile(daythay dt)
        {
        SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@gvn",dt.magiaoviennghi) ,
        };
            return DataProvider.ExecuteNonQuery("xoalichdaythay", para);
        }
        internal static DataTable Timkiemlichdaythay(string magiaoviendaythay)
        {
            return DataProvider.GetData("select * from lichdaythay " + magiaoviendaythay);
        }
                    
                       /// lop hoc 
                     
      public static DataTable Getlistlophoc()
        {
            return DataProvider.GetData("select*from lophoc");
        }
        public static int InsertProfile(lop l)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",l.malh ),
                new SqlParameter("@magv",l.magvcn),
                new SqlParameter("@siso",l.siso),
                new SqlParameter("@nh",l.namnhaphoc),
                new SqlParameter("@kt",l.namketthuc),
                new SqlParameter("@tb",l.tenban)
                
            };
            return DataProvider.ExecuteNonQuery("themlophoc", para);
        }
        public static int UpdateProfile(lop  l)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                 new SqlParameter("@ma",l.malh ),
                new SqlParameter("@magv",l.magvcn),
                new SqlParameter("@siso",l.siso),
                new SqlParameter("@nh",l.namnhaphoc),
                new SqlParameter("@kt",l.namketthuc),
                new SqlParameter("@tb",l.tenban)
            };
            return DataProvider.ExecuteNonQuery("sualophoc", para);
        }
        internal static int DeleteProfile(lop l)
        {
        SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",l.malh),
        };
            return DataProvider.ExecuteNonQuery("xoalophoc", para);
        }
        internal static DataTable Timkiemlophoc(string malop)
        {
            return DataProvider.GetData("select * from lophoc " + malop);
        }
                   // lịch giảng dạy 
        public static DataTable Getlistlichgiangday()
        {
            return DataProvider.GetData("select*from lichgiangday");
        }
        public static int InsertProfile(giangday d)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",d.magv ),
                new SqlParameter("@ten",d.tengv),
                new SqlParameter("@cm",d.chuyenmon),
                new SqlParameter("@gt",d.gioitinh),
                new SqlParameter("@thu",d.thu),
                new SqlParameter("@buoi",d.buoi),
                new SqlParameter("@tiet",d.tiet),
                new SqlParameter("@lop",d.malop),
                new SqlParameter("@tuan",d.tuan)
                
            };
            return DataProvider.ExecuteNonQuery("themlichgiangday", para);
        }
        public static int UpdateProfile(giangday d)
        {
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@ma",d.magv ),
                new SqlParameter("@ten",d.tengv), 
                new SqlParameter("@tiet",d.tiet),
                new SqlParameter("@lop",d.malop),
                new SqlParameter("@buoi",d.buoi)
            };
            return DataProvider.ExecuteNonQuery("sualichgiangday", para);
        }
        internal static int DeleteProfile( giangday d)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",d.magv),
        };
            return DataProvider.ExecuteNonQuery("xoalichgiangday", para);
        }
        internal static DataTable Timkiemlichgiangday(string magv)
        {
            return DataProvider.GetData("select * from lichgiangday " +magv);
        }
        
        /// / lich phân công công tác giảng dạy
         
        public static DataTable Getlistphancong()
        {
            return DataProvider.GetData("select*from phanconggiangday");
        }
        public static int InsertProfile(phancong c)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",c.magv ),
                new SqlParameter("@ten",c.tengv),
                new SqlParameter("@tn",c.tungay),
                new SqlParameter("@dn",c.denngay),
                new SqlParameter("@ct",c.congtac),
                new SqlParameter("@ghichu",c.ghichu)
                 
                
            };
            return DataProvider.ExecuteNonQuery("themphancong", para);
        }
        public static int UpdateProfile(phancong c)
        {
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@ma",c.magv ),
                new SqlParameter("@ten",c.tengv),
                new SqlParameter("@tn",c.tungay),
                new SqlParameter("@dn",c.denngay),
                new SqlParameter("@ct",c.congtac)
            };
            return DataProvider.ExecuteNonQuery("suaphancong", para);
        }
        internal static int DeleteProfile(phancong c)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",c.magv),
        };
            return DataProvider.ExecuteNonQuery("xoaphancong", para);
        }
        internal static DataTable Timkiemlichphancong(string magv)
        {
            return DataProvider.GetData("select * from phanconggiangday " + magv);
        }

        // các môn học 
        public static DataTable Getlistmonhoc()
        {
            return DataProvider.GetData("select*from cacmonhoc");
        }
        public static int InsertProfile(monhoc m)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",m.mamh ),
                new SqlParameter("@ten",m.tenmonhoc),
                
            };
            return DataProvider.ExecuteNonQuery("themmonhoc", para);
        }
        public static int UpdateProfile(monhoc m)
        {
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@ma",m.mamh ),
                new SqlParameter("@ten",m.tenmonhoc),
                 
            };
            return DataProvider.ExecuteNonQuery("suamonhoc", para);
        }
        internal static int DeleteProfile(monhoc m)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",m.mamh),
        };
            return DataProvider.ExecuteNonQuery("xoamonhoc", para);
        }
        internal static DataTable Timkiemmonhoc(string tenmonhoc)
        {
            return DataProvider.GetData("select * from cacmonhoc " + tenmonhoc);
        }

        // thông tin  học sinh 
        public static DataTable Getlisthocsinh()
        {
            return DataProvider.GetData("select*from hocsinh");
        }
        public static int InsertProfile(hocsinh h)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",h.mahs ),
                new SqlParameter("@malh",h.malh),
                new SqlParameter("@ten",h.tenhs),
                new SqlParameter("@dc",h.diachi),
                new SqlParameter("@dt",h.dantoc),
                new SqlParameter("@ns",h.ngaysinh),
                new SqlParameter("@gt",h.gioitinh),
                new SqlParameter("@ghichu",h.ghichu),
                new SqlParameter("@nt",h.ngaynhaphoc),
                new SqlParameter("@rt",h.ngayratruong),
                new SqlParameter("@sk",h.suckhoe)
                
                  
            };
            return DataProvider.ExecuteNonQuery("themhocsinh", para);
        }
        public static int UpdateProfile(hocsinh h)
        {
            SqlParameter[] para = new SqlParameter[] 
            { 
                 new SqlParameter("@ma",h.mahs ),
                new SqlParameter("@malh",h.malh), 
                new SqlParameter("@dc",h.diachi) 
                
            };
            return DataProvider.ExecuteNonQuery("suahocsinh", para);
        }
        internal static int DeleteProfile(hocsinh h)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",h.mahs) 
        };
            return DataProvider.ExecuteNonQuery("xoahocsinh", para);
        }
        internal static DataTable Timkiemhocsinh (string mahs)
        {
            return DataProvider.GetData("select * from hocsinh  " +mahs);
        }

        // bảng điểm 
        public static DataTable Getlistbangdiem()
        {
            return DataProvider.GetData("select*from bangdiem");
        }
        public static int InsertProfile(bangdiem b)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter ("@ma",b.mabd),
                 new SqlParameter("@mahs",b.mahs),
                 new SqlParameter("@tb",b.diemtb),
                 new SqlParameter("@toan",b.diemtoan),
                 new SqlParameter("@van",b.diemvan),
                 new SqlParameter("@anh",b.diemanh),
                  new SqlParameter("@hoa",b.diemhoa),
                 new SqlParameter("@ly",b.diemly),
                 new SqlParameter("@sinh",b.diemsinh),
                 new SqlParameter("@su",b.diemsu),
                 new SqlParameter("@dia",b.diemdia),
                 new SqlParameter("@gv",b.giaovienquanly)
                
            };
            return DataProvider.ExecuteNonQuery("thembangdiem", para);
        }
        public static int UpdateProfile(bangdiem b)
        {
            SqlParameter[] para = new SqlParameter[] 
            { 
               new SqlParameter ("@ma",b.mabd),
                 new SqlParameter("@mahs",b.mahs),
                 new SqlParameter("@tb",b.diemtb),
                 new SqlParameter("@toan",b.diemtoan),
                 new SqlParameter("@van",b.diemvan),
                 new SqlParameter("@anh",b.diemanh),
                 new SqlParameter("@hoa",b.diemhoa),
                 new SqlParameter("@ly",b.diemly),
                 new SqlParameter("@sinh",b.diemsinh),
                 new SqlParameter("@su",b.diemsu),
                 new SqlParameter("@dia",b.diemdia),
                 new SqlParameter("@gv",b.giaovienquanly)
            };
            return DataProvider.ExecuteNonQuery("suabangdiem", para);
        }
        internal static int DeleteProfile(bangdiem b)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",b.mabd),
        };
            return DataProvider.ExecuteNonQuery("xoabangdiem", para);
        }
        internal static DataTable Timkiembangdiem(string mabd)
        {
            return DataProvider.GetData("select * from bangdiem " + mabd);
        }
        
        // chi tiết bảng điểm 
        public static DataTable Getlistchitietbangdiem()
        {
            return DataProvider.GetData("select*from chitietbangdiem");
        }
        public static int InsertProfile( chitietbangdiem ct)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ct.mactd),
                new SqlParameter("@mahs",ct.mahs),
                new SqlParameter("@mamh",ct.mamh),
                new SqlParameter("@dm",ct.diemmieng),
                new SqlParameter("@15p1",ct.diem15p1),
                new SqlParameter("@15p2",ct.diem15p2),
                new SqlParameter("@45p1",ct.diem45p1),
                new SqlParameter("@45p2",ct.diem45p2),
                new SqlParameter("@hk",ct.diemhocky),
                new SqlParameter("@tb",ct.diemtbmon),
                new SqlParameter("@mabd",ct.mabd)
            };
            return DataProvider.ExecuteNonQuery("themchitietbangdiem", para);
        }
        public static int UpdateProfile(chitietbangdiem ct)
        {
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@ma",ct.mactd),
                new SqlParameter("@mahs",ct.mahs),
                new SqlParameter("@mamh",ct.mamh),
                new SqlParameter("@dm",ct.diemmieng),
                new SqlParameter("@15p1",ct.diem15p1),
                new SqlParameter("@15p2",ct.diem15p2),
                new SqlParameter("@45p1",ct.diem45p1),
                new SqlParameter("@45p2",ct.diem45p2),
                new SqlParameter("@hk",ct.diemhocky),
                new SqlParameter("@tb",ct.diemtbmon),
                new SqlParameter("@mabd",ct.mabd)
            };
            return DataProvider.ExecuteNonQuery("suachitietbangdiem", para);
        }
        internal static int DeleteProfile(chitietbangdiem ct)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",ct.mactd),
        };
            return DataProvider.ExecuteNonQuery("xoachitietbangdiem", para);
        }
        internal static DataTable Timkiemchitietbangdiem(string mahs)
        {
            return DataProvider.GetData("select * from chitietbangdiemy " +mahs);
        }
        //thân nhân 
        public static DataTable Getlistthannhan()
        {
            return DataProvider.GetData("select*from thannhan");
        }
        public static int InsertProfile(thannhan t)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@ma",t.mahs),
                 new SqlParameter("@tenbo",t.hotenbo),
                 new SqlParameter("@dcbo",t.diachi),
                 new SqlParameter("@nsbo",t.ngaysinh),
                 new SqlParameter("@nnbo",t.nghenghiep),
                 new SqlParameter("@tenme",t.hotenme),
                 new SqlParameter("@dcme",t.diachime),
                 new SqlParameter("@nsme",t.ngaysinhme),
                 new SqlParameter("@nnme",t.nghenghiepme) 
             };
            return DataProvider.ExecuteNonQuery("themthannhan", para);
        }
        public static int UpdateProfile(thannhan t)
        {
            SqlParameter[] para = new SqlParameter[] 
            { 
                new SqlParameter("@ma",t.mahs),
                 new SqlParameter("@tenbo",t.hotenbo),
                 new SqlParameter("@dcbo",t.diachi),
                 new SqlParameter("@nsbo",t.ngaysinh),
                 new SqlParameter("@nnbo",t.nghenghiep),
                 new SqlParameter("@tenme",t.hotenme),
                 new SqlParameter("@dcme",t.diachime),
                 new SqlParameter("@nsme",t.ngaysinhme),
                 new SqlParameter("@nnme",t.nghenghiepme) 
            };
            return DataProvider.ExecuteNonQuery("suathannhan", para);
        }
        internal static int DeleteProfile(thannhan t)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",t.mahs),
        };
            return DataProvider.ExecuteNonQuery("xoathannhan", para);
        }
        internal static DataTable Timkiemthannhan(string mahs)
        {
            return DataProvider.GetData("select * from thannhan " + mahs);
        }

        // học bạ 
        public static DataTable Getlisthocba()
        {
            return DataProvider.GetData("select*from hocba");
        }
        public static int InsertProfile(hocba hb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@ma",hb.mahb),
                 new SqlParameter("@mahs",hb.mahs),
                 new SqlParameter("@magv",hb.magv),
                 new SqlParameter("@tb",hb.diemtb),
                 new SqlParameter("@hl",hb.hocluc),
                 new SqlParameter("@hk",hb.hanhkiem),
                 new SqlParameter("@vp",hb.thongtinvipham),
                 new SqlParameter("@kl",hb.kyluat),
                 new SqlParameter("@kt",hb.khenthuong),
                 new SqlParameter("@dg",hb.danggiagv),
                 new SqlParameter("@ghichu",hb.ghichu),
                 new SqlParameter("@hocky",hb.hocky)
            };
            return DataProvider.ExecuteNonQuery("themhocba", para);
        }
        public static int UpdateProfile(hocba hb)
        {
            SqlParameter[] para = new SqlParameter[] 
            { 
                 new SqlParameter("@ma",hb.mahb), 
                 new SqlParameter("@tb",hb.diemtb),
                 new SqlParameter("@hl",hb.hocluc),
                 new SqlParameter("@hk",hb.hanhkiem),
                 new SqlParameter("@vp",hb.thongtinvipham),
                 new SqlParameter("@kl",hb.kyluat),
                 new SqlParameter("@kt",hb.khenthuong),
                 new SqlParameter("@dg",hb.danggiagv),
                 new SqlParameter("@ghichu",hb.ghichu),
                 new SqlParameter("@hocky",hb.hocky)
            };
            return DataProvider.ExecuteNonQuery("suahocba", para);
        }
        internal static int DeleteProfile(hocba hb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter ("@ma",hb.mahb),
        };
            return DataProvider.ExecuteNonQuery("xoahocba", para);
        }
        internal static DataTable Timkiemhocba(string mahs)
        {
            return DataProvider.GetData("select * from hocba " + mahs);
        }
    }
}
