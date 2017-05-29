
                                    --THÊM GIÁO VIÊN 

create proc themhsgiaovien @ma char(10),@ten nvarchar(50) ,@ns datetime ,@gt nvarchar(50),@dt char(50),@tg nvarchar(50),@que  nvarchar(50),@td nvarchar(50),
@ngay datetime,@nn nvarchar(50),@ghichu nvarchar(50), @tb nvarchar(50) 
as
begin
insert into giaovien(magv,tengv,ngaysinh,gioitinh,dantoc,tongiao,quequan,trinhdo,ngayvaolam,ngoaingu,ghichu,tenban)
values (@ma,@ten,@ns,@gt,@dt,@tg,@que,@td,@ngay,@nn,@ghichu,@tb)

end 
themhsgiaovien 'gv01234',N'huyền','02/02/1996',N'nữ','kinh','không',N'hà tĩnh','không','04/03/2015','anh','không',N'toán'
select *from giaovien
                                   --SỬA THÔNG TIN GIÁO VIÊN 
create proc suathongtingiaovien @ma char(10),@ten nvarchar(50),@ns date,@td nvarchar(50)
as
begin
update giaovien
set ngaysinh=@ns,trinhdo=@td   
where magv=@ma
end
 


                                   --XÓA THÔNG TIN GIÁO VIÊN  
create proc xoathongtingiaovien  @ma char(10)
as
begin
delete giaovien
where magv=@ma
 
end  


                           
						           --THÊM BAN BỘ MÔN
CREATE proc themphongban @ten nvarchar(50) ,@tb char(10),@sogv int
as
begin 
insert into banbomon(tenban,truongban,sogvdg)
values (@ten,@tb,@sogv)
end

themphongban N'lịch sử','gv009','21'
select * from banbomon 
                                   --SỬA BAN BỘ MÔN 

create proc suaphongban @ten nvarchar(50) ,@tb char(10),@sogv int
as
begin
update banbomon
set truongban=@tb ,sogvdg=@sogv 
where tenban=@ten
end
								   --XÓA BAN BỘ MÔN
create proc xoaphongban  @ten nvarchar(50)
as
begin 
delete  banbomon  
where  tenban=@ten 
end  
 

       
	                             ---THÊM THÔNG TIN LỊCH DẠY THAY
                                    
CREATE proc themlichdaythay @thu int,@tuan int,@buoi nvarchar(50), @tiet char(10),@lop char(10),@gvn char(10),@gvd char(10)
as
begin 
insert into lichdaythay(thu,tuan,buoi,tiet,lop,magiaoviennghi,magiaoviendaythay)
values (@thu,@tuan,@buoi,@tiet,@lop,@gvn,@gvd)
end 

								 ---SỬA THÔNG TIN LỊCH  DẠY THAY
create proc sualichdaythay   @tiet char(10),@lop char(10),@gvn char(10),@gvd char(10)
as
begin
update lichdaythay
set tiet=@tiet,lop=@lop,magiaoviendaythay=@gvd
where magiaoviennghi=@gvn
end 
								 ---XÓA THÔNG TIN LỊCH DẠY THAAY

create proc xoalichdaythay  @gvn char(10)
as
begin
delete lichdaythay
where magiaoviennghi=@gvn
                                 
 end


                                   --THÊM LỊCH GIẢNG DẠY 
create proc themlichgiangday @ma char(10),@ten nvarchar(50),@cm nvarchar(50) ,@buoi nvarchar(50),@thu char(10) , @tiet char(10) ,@lop char(10),@tuan char(10)
as
begin  
insert into lichgiangday(magv,tengv,chuyenmon,buoi,thu,tiet,malop,tuan )
values (@ma,@ten,@cm,@buoi,@thu,@tiet,@lop,@tuan)
end  
themlichgiangday 'gv09',N'Ngô Thanh Ngần','day anh','3','chieu','4','10A2','44' 
themlichgiangday 'gv02','Nguyễn Xuân Hải','day anh','nam','3','chieu','3','10A2','44'
								   --SỬA LỊCH GIẢNG DẠY 
create proc sualichgiangday  @ma char(10),@ten nvarchar(50), @tiet char(10),@lop char(10),@buoi nvarchar(50)
as
begin
update lichgiangday
set  tiet=@tiet,buoi=@buoi  
where magv=@ma
end 
sualichgiangday'gv09',N'Ngô Thanh Ngần','3','10A3'

 
								   --XÓA LỊCH GIẢNG DẠY
create proc xoalichgiangday @ma char(10) 
as
begin
delete lichgiangday
where magv=@ma
                                 
 end 


								   --thêm lịch phân công giảng dạy
CREATE proc themphancong @ma char(10),@ten nvarchar(50) ,@tn datetime,@dn datetime,@ct nvarchar(50),@ghichu nvarchar(50)
as
begin  
insert into phanconggiangday(magv,tengv,tungay,denngay,congtac,ghichu) 
values (@ma,@ten,@tn,@dn,@ct,@ghichu)
end  						    
								   --sửa lịch phân công giảng dạy
create proc suaphancong @ma char(10),@ten nvarchar(50) ,@tn datetime,@dn datetime,@ct nvarchar(50) ,@ghichu nvarchar(50)
as
begin
update phanconggiangday
set  tungay=@tn,denngay=@dn,congtac=@ct 
where magv=@ma
end 
								   --xóa lịch phân công giảng dạy 

create proc xoaphancong @ma char(10) 
as
begin
delete phanconggiangday
where magv=@ma                   
 end 	


 							      --thêm lớp học 
CREATE proc themlophoc @ma char(10),@magv char(10) ,@siso int,@nh datetime,@kt datetime,@tb nvarchar(50)  
as
begin  
insert into lophoc(malh,magvcn,siso ,namnhaphoc,namketthuc,tenban)  
values (@ma,@magv,@siso ,@nh,@kt,@tb )
end  								    
	
								   --sửa lớp học 

create proc sualophoc @ma char(10),@magv char(10) ,@siso int,@nh datetime,@kt datetime,@tb nvarchar(50)  
as 
begin
update lophoc
set  magvcn=@magv,tenban=@tb
where malh=@ma
end 								   --xóa lớp học 

create proc xoalophoc @ma char(10) 
as
begin
delete lophoc
where malh=@ma                   
 end  
    
	
	           
			   
			                          --thêm môn học 
CREATE proc themmonhoc @ma char(10), @ten nvarchar(50)
as
begin  
insert into cacmonhoc(mamh,tenmonhoc)
values (@ma,@ten )
end  

									  --sửa môn học 
create proc suamonhoc @ma char(10), @ten nvarchar(50)
as 
begin
update cacmonhoc
set  tenmonhoc=@ten
where mamh=@ma
end 
									  --xóa môn học

create proc xoamonhoc @ma char(10) 
as
begin
delete cacmonhoc
where mamh=@ma                   
 end
 
 
 									  --thêm thông tin cho học sinh
create proc themhocsinh  @ma char(10),@malh char(10), @ten nvarchar(50),@dc nvarchar(50),@dt char(10),@ns datetime,@gt nvarchar(50),@ghichu nvarchar(50),@nt datetime,@rt datetime,@sk nvarchar(50) 
as
begin  
insert into hocsinh(mahs,malh,tenhs,diachi,dantoc,ngaysinh,gioitinh,ghichu,ngaynhaptruong,ngayratruong,suckhoe)
values (@ma,@malh,@ten,@dc,@dt,@ns,@gt,@ghichu,@nt,@rt,@sk)
end  

									  --sửa thông tin học sinh 
create proc suahocsinh  @ma char(10),@malh char(10), @dc nvarchar(50)  
as 
begin
update hocsinh
set  malh=@malh,diachi=@dc 
where mahs=@ma
end 
	
									  --xóa thông tin học sinh
create proc xoahocsinh @ma char(10) 
as
begin
delete hocsinh
where mahs=@ma                   
 end
			
			
			
			
									  --thêm thông tin thân nhân
CREATE proc themthannhan @ma char(10) , @tenbo nvarchar(50), @nsbo date,@dcbo nvarchar(50),@nnbo nvarchar(50),@tenme nvarchar(50),@nsme date,@dcme nvarchar(50),@nnme nvarchar(50)      
as
begin  
insert into  thannhan(mahs,hotenbo,ngaysinh,diachi,nghenghiep,hotenme,ngaysinhme,diachime,nghenghiepme)
values (@ma,@tenbo,@nsbo,@dcbo,@nnbo,@tenme,@nsme,@dcme,@nnme) 
end  									   
									  -- sửa thông tin than nhân 
create proc suathannhan  @ma char(10) , @tenbo nvarchar(50), @nsbo date,@dcbo nvarchar(50),@nnbo nvarchar(50),@tenme nvarchar(50),@nsme date,@dcme nvarchar(50),@nnme nvarchar(50)       
as 
begin
update thannhan
set  hotenbo=@tenbo,diachi=@dcbo,hotenme=@tenme,diachime=@dcme
where mahs=@ma
end 
	
									  -- xóa thông tin thân nhân 
create proc xoathannhan   @ma char(10) 
as
begin
delete thannhan
where mahs=@ma                 
 end




									  -- thêm vào bảng điêm 
create proc thembangdiem  @ma char(10),@mahs char(10),@tb float,@toan float,@van float,@anh float,@hoa float ,@ly float,@sinh float,@su float ,@dia float ,@gv char(10)
as
begin  
insert into  bangdiem(mabd,mahs,diemtb,diemtoan,diemvan,diemanh,diemhoa,diemly,diemsinh,diemsu,diemdia,giaovienquanly) 
values (@ma,@mahs,@tb,@toan,@van,@anh,@hoa,@ly,@sinh,@su,@dia,@gv)
end  
									  --sửa bảng diem
create proc suabangdiem  @ma char(10),@mahs char(10),@tb float,@toan float,@van float,@anh float,@hoa float ,@ly float,@sinh float,@su float ,@dia float ,@gv char(10) 
as
begin
update bangdiem
set   diemtb=@tb,diemtoan=@toan,diemvan=@van,diemanh=@anh,diemhoa=@hoa,diemly=@ly,diemsinh=@sinh,diemsu=@su,diemdia=@dia 
where mabd=@ma
end 
	
									  --xóa bãng điểm 
create proc xoabangdiem @ma char(10) 
as
begin
delete bangdiem
where mabd=@ma                   
 end




									  --thêm  chi tiết bảng điêm 
CREATE proc themchitietbangdiem  @ma char(10),@mahs char(10),@mamh char(10),@dm float,@15p1 float,@15p2 float, @45p1 float,@45p2 float,@hk  float ,@tb float
as
begin  
insert into chitietbangdiem(mactd,mahs,mamh,diemmieng,diem15p1,diem15p2,diem45p1,diem45p2,diemhocky,diemtbmon)
values (@ma,@mahs,@mamh,@dm,@15p1,@15p2,@45p1,@45p2,@hk,@tb)
end  
									  --sửa chi tiet bảng điểm

CREATE proc suachitietbangdiem  @ma char(10),@mahs char(10),@mamh char(10),@dm float,@15p1 float,@15p2 float, @45p1 float,@45p2 float,@hk  float ,@tb float
as 
begin
update chitietbangdiem
set diemmieng=@dm,diem15p1=@15p1,diem15p2=@15p2,diem45p1=@45p1,diem45p2=@45p2,diemhocky=@hk,diemtbmon=@tb  
where mactd=@ma
end 
	
									  --xóa chi tiest bảng điêm 
create proc xoachitietbangdiem @ma char(10) 
as
begin
delete chitietbangdiem
where mactd =@ma                    
 end
			
			
			
				
				
									  -- thêm học bạ 
CREATE proc themhocba  @ma char(10),@mahs char(10),@magv char(10), @tb float,@hl nvarchar(50) ,@hk nvarchar(50),@kl nvarchar(50),@kt nvarchar(50), @dg nvarchar(50),@ghichu nvarchar(50) ,@hocky char(10)
as
begin  
insert into hocba(mahb,mahs,magv,diemtb,hocluc,hanhkiem,kyluat,khenthuong,danhgiagv,ghichu,hocky)
values (@ma,@mahs,@magv,@tb,@hl,@hk,@kl,@kt,@dg,@ghichu,@hocky )
end  
									  -- sửa học bạ
create proc SuaThongTinHocBa @ma char(10),@mahs char(10),@magv char(10), @tb float,@hl nvarchar(50) ,@hk nvarchar(50),@kl nvarchar(50),@kt nvarchar(50), @dg nvarchar(50),@ghichu nvarchar(50) ,@hocky char(10)
as
begin
update hocba
set   kyluat=@kl,khenthuong=@kt
where mahb=@ma
end 
	
									  --xóa học bạ 
create proc xoahocba @ma char(10) 
as
begin
delete hocba
where mahb=@ma                   
 end						
                                      -- thêm khen thưởng
CREATE proc themkhenthuong  @mahs char(10), @ht nvarchar(50), @ld nvarchar(50), @nk datetime
as
begin  
insert into khenthuong(mahs,hinhthuc,lydo,ngaykhenthuong)
values (@mahs,@ht,@ld,@nk)
end  
			           --- sửa khen thưởng
CREATE proc suakhenthuong @mahs char(10), @ht nvarchar(50), @ld nvarchar(50), @nk datetime   
as
begin
update khenthuong
set  hinhthuc=@ht ,lydo = @ld
where mahs=@mahs
end 			
                                 -- xóa khen thưởng
create proc xoakhenthuong @ma char(10) 
as
begin
delete khenthuong
where mahs=@ma                   
 end	
	                                  -- thêm kỷ luật
create proc themkyluat  @mahs char(10), @ht nvarchar(50), @ld nvarchar(50), @nkl datetime ,@ghichu nvarchar(50)
as
begin  
insert into kyluat(mahs,hinhthuc,lydo,ngaykyluat,ghichu)
values (@mahs,@ht,@ld,@nkl,@ghichu)
end  
			           --- sửa kyluat
create proc suakyluat @mahs char(10), @ht nvarchar(50), @ld nvarchar(50), @nkl datetime ,@ghichu  nvarchar(50)
as
begin
update kyluat
set  hinhthuc=@ht ,ngaykyluat =@nkl ,ghichu=@ghichu
where mahs=@mahs
end 	
          ----- xóa kỷ luật
create proc xoakyluat @ma char(10) 
as
begin
delete kyluat
where mahs=@ma                   
 end	
                           ---------thêm lương

CREATE proc themluong @ma char(10),@lcb float ,@hsl float , @lpc float, @bhyt float , @tl float
as 
begin  
insert into bangluong(magv,luongcoban,hesoluong,luongphucap,BaoHiemYTe,TongLuong)
values (@ma,@lcb,@hsl,@lpc,@bhyt,@tl)
end  
			           --- sửa lương
create proc sualuong  @ma char(10),@lcb float ,@hsl float , @lpc float, @bhyt float , @tl float
as
begin
update bangluong
set  luongphucap = @lpc ,TongLuong =@tl
end 	
               --- xóa bảng lương 
			   								   
create proc xoabangluong @ma char(10) 
as
begin
delete bangluong
where magv=@ma
                                 
 end 
 -- xem thân nhân
    --tạo thủ tục xem độc giả quá hạn trả 
 
          				
                             							  			   