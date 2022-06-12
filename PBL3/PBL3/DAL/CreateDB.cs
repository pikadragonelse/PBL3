﻿using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class CreateDB:
                    DropCreateDatabaseAlways<QLKS>
    //CreateDatabaseIfNotExists<QLKS>


    {
        protected override void Seed(QLKS context)
        {

            context.ChucVus.AddRange(new ChucVu[]
          {
                new ChucVu{IdChucVu = "NV",TenChucVu = "Nhan Vien", MoTa = ""},
                new ChucVu{IdChucVu = "AD",TenChucVu = "Quan Ly", MoTa = ""},

          });
            context.NhanViens.AddRange(new NhanVien[]
            {
                new NhanVien{IdNhanVien = "NV01", Username = "NV1",IdChucVu = "NV", Ten="Cao Huu Phuc",GioiTinh=true,NgaySinh=new DateTime(2002,7,7),CMND="197500617",SDT="081666377",DiaChi="Quang Tri"},
                new NhanVien{IdNhanVien="NV02", Username = "NV2",IdChucVu="NV",Ten="Nguyen Ngoc Bao Long",GioiTinh=true,NgaySinh=new DateTime(2002,7,7),CMND="197500617",SDT="081666377",DiaChi="Quang Tri"},
                new NhanVien{IdNhanVien="NV03", Username = "NV3",IdChucVu="NV",Ten="Trinh Quang Vinh",GioiTinh=true,NgaySinh=new DateTime(2002,7,7),CMND="197500617",SDT="081666377",DiaChi="Da Nang"},
                new NhanVien{IdNhanVien="NV04", Username = "AD1",IdChucVu="AD",Ten="Chien Than",GioiTinh=true,NgaySinh=new DateTime(2002,7,7),CMND="197500617",SDT="081666377",DiaChi="Quang Tri"},

            });

            context.LoaiPhongs.AddRange(new LoaiPhong[] {
                new LoaiPhong {IdLoaiPhong = "TD", TenLoaiPhong = "Phòng đơn thường", Gia = "500000"},
                new LoaiPhong {IdLoaiPhong = "TDD", TenLoaiPhong = "Phòng đôi thường", Gia = "1000000"},
                new LoaiPhong {IdLoaiPhong = "VD", TenLoaiPhong = "Phòng đơn VIP", Gia = "3000000"},
                new LoaiPhong {IdLoaiPhong = "VDD", TenLoaiPhong = "Phòng đôi VIP", Gia = "6000000"},
            });

            context.Phongs.AddRange(new Phong[]
            {
                   new Phong {IdPhong = "P1",Name = "Phòng 301", IdLoaiPhong = "TD", TrangThai = true},
                   new Phong {IdPhong = "P2",Name = "Phòng 302", IdLoaiPhong = "TDD", TrangThai = true},
                   new Phong {IdPhong = "P3",Name = "Phòng 303", IdLoaiPhong = "VD", TrangThai = true},
                   new Phong {IdPhong = "P4",Name = "Phòng 304", IdLoaiPhong = "VDD", TrangThai = true},
                   new Phong {IdPhong = "P5",Name = "Phòng 305", IdLoaiPhong = "TD", TrangThai = true},
                   new Phong {IdPhong = "P6",Name = "Phòng 305", IdLoaiPhong = "TD", TrangThai = true},
                   new Phong {IdPhong = "P7",Name = "Phòng 305", IdLoaiPhong = "TD", TrangThai = true},
                   new Phong {IdPhong = "P8",Name = "Phòng 305", IdLoaiPhong = "TD", TrangThai = true},




            });

            context.DoThatLacs.AddRange(new DoThatLac[] {
                new DoThatLac {ID = "1", Name = "Do1", IdPhong = "P1", TinhTrang = "Khách chưa liên hệ"},
                new DoThatLac {ID = "2", Name = "Do2", IdPhong = "P2", TinhTrang = "Đã trả"},
                new DoThatLac {ID = "3", Name = "Do3", IdPhong = "P3", TinhTrang = "Khách đã liên hệ"},
                new DoThatLac {ID = "4", Name = "Do4", IdPhong = "P2", TinhTrang = "Khách chưa liên hệ"},

            });

            context.HoaDons.AddRange(new HoaDon[]
            {
                new HoaDon {IdHoaDon = "1",  NgayThanhToan = new DateTime(2002,7,7), TienPhong = "500", TienDichVu = "100",
                            TienVatTu = "50", TongTien = "650", GhiChu = "123"},

                new HoaDon {IdHoaDon = "2",  NgayThanhToan = new DateTime(2002,7,7), TienPhong = "500", TienDichVu = "100",
                            TienVatTu = "50", TongTien = "650", GhiChu = "123"},

                new HoaDon {IdHoaDon = "3", NgayThanhToan = new DateTime(2002,7,9), TienPhong = "500", TienDichVu = "100",
                            TienVatTu = "50", TongTien = "650", GhiChu = "123"},

                new HoaDon {IdHoaDon = "4", NgayThanhToan = new DateTime(2002,7,8), TienPhong = "500", TienDichVu = "100",
                            TienVatTu = "50", TongTien = "650", GhiChu = "123"},

                new HoaDon {IdHoaDon = "5", NgayThanhToan = new DateTime(2002,7,8), TienPhong = "500", TienDichVu = "100",
                            TienVatTu = "50", TongTien = "650", GhiChu = "123"},

            });

            context.KhachHangs.AddRange(new KhachHang[]
            {
                  new KhachHang {IdKhachHang="1", Ten = "NVA", GioiTinh = true, CMND = "197464151", SDT = "0862027357", QuocTich = "VN"},
                  new KhachHang {IdKhachHang="2", Ten = "NVB", GioiTinh = false, CMND = "197464151", SDT = "0862027357", QuocTich = "VN"},
                  new KhachHang {IdKhachHang="3", Ten = "NVC", GioiTinh = false, CMND = "197464151", SDT = "0862027357", QuocTich = "VN"},
                  new KhachHang {IdKhachHang="4", Ten = "NVD", GioiTinh = true, CMND = "197464151", SDT = "0862027357", QuocTich = "VN"},
                  new KhachHang {IdKhachHang="5", Ten = "NVE", GioiTinh = true, CMND = "197464151", SDT = "0862027357", QuocTich = "VN"},

            });


            context.LichSuDangNhaps.AddRange(new LichSuDangNhap[]
            {
                new LichSuDangNhap {idLichSuDangNhap = "1", idNhanVien = "NV01", TrangThai = true, ThoiGian = new DateTime(2022,02,03)},
                new LichSuDangNhap {idLichSuDangNhap = "2", idNhanVien = "NV01", TrangThai = false, ThoiGian = new DateTime(2022,02,03)},
                new LichSuDangNhap {idLichSuDangNhap = "3", idNhanVien = "NV02", TrangThai = true, ThoiGian = new DateTime(2022,02,03)},
                new LichSuDangNhap {idLichSuDangNhap = "4", idNhanVien = "NV02", TrangThai = false, ThoiGian = new DateTime(2022,02,03)},
                new LichSuDangNhap {idLichSuDangNhap = "5", idNhanVien = "NV03", TrangThai = true, ThoiGian = new DateTime(2022,02,03)},

            });

            context.LoaiDichVus.AddRange(new LoaiDichVu[]
            {
                new LoaiDichVu {IdDichVu = "1", TenDichVu = "DV01", DonGia = "100"},
                new LoaiDichVu {IdDichVu = "2", TenDichVu = "DV02", DonGia = "1000"},
                new LoaiDichVu {IdDichVu = "3", TenDichVu = "DV03", DonGia = "1005"},
                new LoaiDichVu {IdDichVu = "4", TenDichVu = "DV04", DonGia = "700"},
                new LoaiDichVu {IdDichVu = "5", TenDichVu = "DV05", DonGia = "800"},

            });

            context.LoaiVatDungs.AddRange(new LoaiVatDung[] { 
                new LoaiVatDung {IdLoaiVatDung = "1", TenVatDung = "VD1", DonGia = "150"},
                new LoaiVatDung {IdLoaiVatDung = "2", TenVatDung = "VD2", DonGia = "100"},
                new LoaiVatDung {IdLoaiVatDung = "3", TenVatDung = "VD3", DonGia = "800"},
                new LoaiVatDung {IdLoaiVatDung = "4", TenVatDung = "VD4", DonGia = "200"},

            });

            context.TrangThaiVatDungs.AddRange(new TrangThaiVatDung[] { 
                new TrangThaiVatDung {IdTrangThaiVatDung = "1", MoTa = "Bình thường"},
                new TrangThaiVatDung {IdTrangThaiVatDung = "2", MoTa = "Hỏng"}
            });


            context.VatDungPhongs.AddRange(new VatDungPhong[] { 
                new VatDungPhong {IdVatDung = "1", IdTrangThaiVatDung = "1", IdPhong = "P1", SoLuongBanDau = 5, SoLuongHienTai = 4, IdLoaiVatDung = "1" },
                new VatDungPhong {IdVatDung = "2", IdTrangThaiVatDung = "2", IdPhong = "P2", SoLuongBanDau = 5, SoLuongHienTai = 4, IdLoaiVatDung = "2" },
                new VatDungPhong {IdVatDung = "3", IdTrangThaiVatDung = "2", IdPhong = "P3", SoLuongBanDau = 5, SoLuongHienTai = 4, IdLoaiVatDung = "3" },
                new VatDungPhong {IdVatDung = "4", IdTrangThaiVatDung = "1", IdPhong = "P4", SoLuongBanDau = 5, SoLuongHienTai = 4, IdLoaiVatDung = "4" },
                new VatDungPhong {IdVatDung = "5", IdTrangThaiVatDung = "1", IdPhong = "P1", SoLuongBanDau = 5, SoLuongHienTai = 4, IdLoaiVatDung = "1" },

            });

            context.Books.AddRange(new Book[]
            {
                new Book {IdBook = "1", IdHoaDon = "1", IdKhachHang = "1", IdNhanVien = "NV01",
                    NgayCheckInThucTe =  new DateTime(2002,7,7), NgayCheckOutThucTe = new DateTime(2002,7,7)},
                new Book {IdBook = "2", IdHoaDon = "2", IdKhachHang = "2", IdNhanVien = "NV02",
                    NgayCheckInThucTe =  new DateTime(2002,7,7), NgayCheckOutThucTe = new DateTime(2002,7,7)},
                new Book {IdBook = "3", IdHoaDon = "4", IdKhachHang = "3", IdNhanVien = "NV03",
                    NgayCheckInThucTe =  new DateTime(2002,7,7), NgayCheckOutThucTe = new DateTime(2002,7,7)},
                new Book {IdBook = "4", IdHoaDon = "3", IdKhachHang = "4", IdNhanVien = "NV04",
                    NgayCheckInThucTe =  new DateTime(2002,7,7), NgayCheckOutThucTe = new DateTime(2002,7,7)},
                new Book {IdBook = "5", IdHoaDon = "2", IdKhachHang = "2", IdNhanVien = "NV04",
                    NgayCheckInThucTe =  new DateTime(2002,7,7), NgayCheckOutThucTe = new DateTime(2002,7,7)},

            });
            

            context.BookDetails.AddRange(new BookDetail[]
{
                new BookDetail {IdBookDetail = "1" ,IdBook = "1", IdPhong = "P1"},
                new BookDetail {IdBookDetail = "2" ,IdBook = "1", IdPhong = "P2"},
                new BookDetail {IdBookDetail = "3" ,IdBook = "1", IdPhong = "P3"},
                new BookDetail {IdBookDetail = "4" ,IdBook = "2", IdPhong = "P5"},
                new BookDetail {IdBookDetail = "5" ,IdBook = "3", IdPhong = "P6"},
                new BookDetail {IdBookDetail = "6" ,IdBook = "4", IdPhong = "P7"},
                new BookDetail {IdBookDetail = "7" ,IdBook = "5", IdPhong = "P8"},
                new BookDetail {IdBookDetail = "8" ,IdBook = "4", IdPhong = "P4"},


});


            context.DangNhaps.AddRange(new DangNhap[]
            {
                new DangNhap {Username = "NV1", MatKhau = "NhanVien", TrangThai = false, IdChucVu = "NV"},
                new DangNhap {Username = "NV2", MatKhau = "NhanVien", TrangThai = false, IdChucVu = "NV"},
                new DangNhap {Username = "NV3", MatKhau = "NhanVien", TrangThai = false, IdChucVu = "NV"},
                new DangNhap {Username = "AD1", MatKhau = "Admin", TrangThai = true, IdChucVu = "AD"},
                new DangNhap {Username = "NV4", MatKhau = "NhanVien", TrangThai = false, IdChucVu = "NV"},

            });



            base.Seed(context);
        }
    }
}