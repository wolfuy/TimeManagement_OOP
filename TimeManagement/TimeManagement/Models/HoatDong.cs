using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagement.Models
{
    public abstract class HoatDong : InterFace_Thongbao
    {
        private string _tenCongViec;

        public string TenCongViec
        {
            get { return _tenCongViec; }
            set { _tenCongViec = value; }
        }
        
        public DateTime ThoiGianBatDau {  get; set; }
        public DateTime ThoiGianKetThuc {  get; set; }
        public bool DaHoanThanh {  get; set; }

        // Constructor
        protected HoatDong(string tenCongViec, DateTime batdau,DateTime ketThuc)
        {
            TenCongViec = tenCongViec;
            ThoiGianBatDau = batdau;
            ThoiGianKetThuc = ketThuc;
            DaHoanThanh = false;
        }

        // Phương thức trừu tượng
        public abstract double TinhTienDo();
        // Interface
        public string HienThiThongBao()
        {
            return $"Bạn có lịch: {TenCongViec} vào lúc {ThoiGianBatDau:HH:mm}";
        }
    }
}
