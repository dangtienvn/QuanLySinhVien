using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;

        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_TaiKhoan();
                return instance;
            }
            private set { instance = value; }
        }

        private DAL_TaiKhoan() { }

        public bool Them(string ten, string matKhau, string loai)
        {
            string sql = "INSERT INTO TAIKHOAN (TenDangNhap, MatKhau, LoaiTaiKhoan) VALUES (@TenDangNhap, @MatKhau, @loaiTaiKhoan)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matKhau, loai });
            
        }

        public bool Sua(string ten, string matKhau, string loai, int id)
        {
            string sql = "UPDATE TAIKHOAN SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, LoaiTaiKhoan = @loaiTaiKhoan WHERE id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matKhau, loai , id});

        }

        public bool Xóa(int id)
        {
            string sql = "DELETE FROM TAIKHOAN Where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });

        }

        public DataTable DanhSach() 
        {
            return KetNoi.Instance.ExcuteQuery("SELECT * FROM TAIKHOAN");
        }

        internal bool Them(object tendangnhap, string matkhau, string loaitaikhoan)
        {
            throw new NotImplementedException();
        }
    }
}
