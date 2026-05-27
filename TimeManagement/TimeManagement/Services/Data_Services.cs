using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace TimeManagement.Services
{
    public class Data_Services
    {
        private readonly string _filePath = "LichTrinh_Data.json";
        public void LuuDuLieu<T>(List<T> danhSach)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(danhSach, options);
            File.WriteAllText(_filePath, jsonString);
        }

        //Hàm lấy dữ liệu lên
        public List<T> DocDuLieu<T>()
        {
            if (!File.Exists(_filePath))
            {
                return new List<T>(); // Nếu chưua có file thì trả danh sách rỗng
            }
            string jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
        }
        public string ant { get; set; }
        // cuwc cho awn cut


    }
}
