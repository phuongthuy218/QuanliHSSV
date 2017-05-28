 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using quanlyhocsinhgiaovien.DataAccessLayer;
using quanlyhocsinhgiaovien.ValueObject;


namespace quanlyhocsinhgiaovien.BusinessLogicLayer
{
    class Bus
    {
        public static DataTable Getlistgiaovien()
        {
            return Dao.Getlistgiaovien();
        }
        public static int InsertProfile(giaovien gv)
        {
            return Dao.InsertProfile(gv);
        }
        public static int UpdateProfile(giaovien gv)
        {
            return Dao.UpdateProfile(gv);
        }
        public static int DeleteProfile(giaovien gv)
        {
            return Dao.DeleteProfile(gv);
        }
        public static DataTable Timkiemgv(string magv)
        {
            return Dao.Timkiemgv(magv);
        }
        // ban bo mon 
        public static DataTable Getlistphongban()
        {
            return Dao.Getlistphongban();
        }
        public static int InsertProfile(phongban bm)
        {
            return Dao.InsertProfile(bm);
        }
        public static int UpdateProfile(phongban bm)
        {
            return Dao.UpdateProfile(bm);
        }
        public static int DeleteProfile(phongban bm)
        {
            return Dao.DeleteProfile(bm);
        }
        public static DataTable Timkiembm(string tenban)
        {
            return Dao.Timkiembm(tenban);
        }

        // lịch day thay 
        public static DataTable Getlistlichdaythay()
        {
            return Dao.Getlistlichdaythay();
        }
        public static int InsertProfile(daythay dt)
        {
            return Dao.InsertProfile(dt);
        }
        public static int UpdateProfile(daythay dt)
        {
            return Dao.UpdateProfile(dt);
        }
        public static int DeleteProfile(daythay dt)
        {
            return Dao.DeleteProfile(dt);
        }
        public static DataTable Timkiemlichdaythay(string magiaoviendaythay)
        {
            return Dao.Timkiemlichdaythay(magiaoviendaythay);
        }
        /// lop hoc 
        public static DataTable Getlistlophoc()
        {
            return Dao.Getlistlophoc();
        }
        public static int InsertProfile(lop l)
        {
            return Dao.InsertProfile(l);
        }
        public static int UpdateProfile(lop l)
        {
            return Dao.UpdateProfile(l);
        }
        public static int DeleteProfile(lop l)
        {
            return Dao.DeleteProfile(l);
        }
        public static DataTable Timkiemlophoc(string malh)
        {
            return Dao.Timkiemlophoc(malh);

        }
                     ///lich giang day 
        public static DataTable Getlistlichgiangday()
        {
            return Dao.Getlistlichgiangday();
        }
        public static int InsertProfile(giangday d)
        {
            return Dao.InsertProfile(d);
        }
        public static int UpdateProfile(giangday d)
        {
            return Dao.UpdateProfile(d);
        }
        public static int DeleteProfile(giangday d)
        {
            return Dao.DeleteProfile(d);
        }
        public static DataTable Timkiemlichgiangday(string magv)
        {
            return Dao.Timkiemlichgiangday(magv);

        }
          /// lịch phân công công tác giảng dạy 
        public static DataTable Getlistphancong()
        {
            return Dao.Getlistphancong();
        }
        public static int InsertProfile(phancong c)
        {
            return Dao.InsertProfile(c);
        }
        public static int UpdateProfile(phancong c)
        {
            return Dao.UpdateProfile(c);
        }
        public static int DeleteProfile(phancong c)
        {
            return Dao.DeleteProfile(c);
        }
        public static DataTable Timkiemlichphancong(string magv)
        {
            return Dao.Timkiemlichphancong(magv);

        }  

         /// các môn học 
        public static DataTable Getlistmonhoc()
        {
            return Dao.Getlistmonhoc();
        }
        public static int InsertProfile(monhoc m)
        {
            return Dao.InsertProfile(m);
        }
        public static int UpdateProfile(monhoc m)
        {
            return Dao.UpdateProfile(m);
        }
        public static int DeleteProfile(monhoc m )
        {
            return Dao.DeleteProfile(m);
        }
        public static DataTable Timkiemmonhoc(string tenmonhoc)
        {
            return Dao.Timkiemmonhoc(tenmonhoc);

        }  

        //// thông tin học sinh 
        public static DataTable Getlisthocsinh()
        {
            return Dao.Getlisthocsinh();
        }
        public static int InsertProfile(hocsinh h)
        {
            return Dao.InsertProfile(h);
        }
        public static int UpdateProfile(hocsinh h)
        {
            return Dao.UpdateProfile(h);
        }
        public static int DeleteProfile(hocsinh h)
        {
            return Dao.DeleteProfile(h);
        }
        public static DataTable Timkiemhocsinh(string mahs)
        {
            return Dao.Timkiemhocsinh(mahs);

        }  

        /// bảng điểm 
        public static DataTable Getlistbangdiem()
        {
            return Dao.Getlistbangdiem();
        }
        public static int InsertProfile(bangdiem b)
        {
            return Dao.InsertProfile(b);
        }
        public static int UpdateProfile(bangdiem b)
        {
            return Dao.UpdateProfile(b);
        }
        public static int DeleteProfile(bangdiem b)
        {
            return Dao.DeleteProfile(b);
        }
        public static DataTable Timkiembangdiem(string mabd)
        {
            return Dao.Timkiembangdiem(mabd);

        }  

        // chi tiêt bảng điểm 
        public static DataTable Getlistchitietbangdiem()
        {
            return Dao.Getlistchitietbangdiem();
        }
        public static int InsertProfile(chitietbangdiem ct)
        {
            return Dao.InsertProfile(ct);
        }
        public static int UpdateProfile(chitietbangdiem ct)
        {
            return Dao.UpdateProfile(ct);
        }
        public static int DeleteProfile(chitietbangdiem ct)
        {
            return Dao.DeleteProfile(ct);
        }
        public static DataTable Timkiemchitietbangdiem(string mahs)
        {
            return Dao.Timkiemchitietbangdiem(mahs);

        }  

        /// thân nhân gia đình 
        public static DataTable Getlistthannhan()
        {
            return Dao.Getlistthannhan();
        }
        public static int InsertProfile(thannhan t)
        {
            return Dao.InsertProfile(t);
        }
        public static int UpdateProfile(thannhan t)
        {
            return Dao.UpdateProfile(t);
        }
        public static int DeleteProfile(thannhan t)
        {
            return Dao.DeleteProfile(t);
        }
        public static DataTable Timkiemthannhan (string mahs)
        {
            return Dao.Timkiemthannhan(mahs);

        }  


        // học bạ 

        public static DataTable Getlisthocba()
        {
            return Dao.Getlisthocba();
        }
        public static int InsertProfile(hocba hb)
        {
            return Dao.InsertProfile(hb);
        }
        public static int UpdateProfile(hocba hb)
        {
            return Dao.UpdateProfile(hb);
        }
        public static int DeleteProfile(hocba hb)
        {
            return Dao.DeleteProfile(hb);
        }
        public static DataTable Timkiemhocba(string mahs)
        {
            return Dao.Timkiemhocba(mahs);

        }

        // bảng lương
        public static DataTable Getlistbangluong()
        {
            return Dao.Getlistbangluong();
        }
        public static int InsertProfile(bangluong bl)
        {
            return Dao.InsertProfile(bl);
        }
        public static int UpdateProfile(bangluong bl )
        {
            return Dao.UpdateProfile(bl);
        }
        public static int DeleteProfile(bangluong bl)
        {
            return Dao.DeleteProfile(bl);
        }
        // kỷ luật 
        public static DataTable Getlistkyluat()
        {
            return Dao.Getlistkyluat();
        }
        public static int InsertProfile(kyluat kl)
        {
            return Dao.InsertProfile(kl);
        }
        public static int UpdateProfile(kyluat kl)
        {
            return Dao.UpdateProfile(kl);
        }
        public static int DeleteProfile(kyluat kl)
        {
            return Dao.DeleteProfile(kl);
        }
        /// khen thuong
        public static DataTable Getlistkhenthuong()
        {
            return Dao.Getlistkhenthuong();
        }
        public static int InsertProfile(khenthuong kt)
        {
            return Dao.InsertProfile(kt);
        }
        public static int UpdateProfile(khenthuong kt)
        {
            return Dao.UpdateProfile(kt);
        }
        public static int DeleteProfile(khenthuong kt)
        {
            return Dao.DeleteProfile(kt);
        }
    }
}