using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.Utils
{
    public class DBCommands
    {
        public static readonly string HOME_QUERY_GET_ALL = "SELECT * FROM NHA";
        public static readonly string HOME_QUERY_SAVE = "INSERT NHA(MaNha, TenChuNha, GiaThue, DaChoThue)" +
                                                        "VALUES(@pr1, @pr2, @pr3, @pr4)";
        public static readonly string HOME_QUERY_UPDATE = "UPDATE NHA\r\t" +
                                                            "SET TenChuNha = @pr2, GiaThue = @pr3, DaChoThue = @pr4\r\t" +
                                                            "WHERE MaNha = @pr1\r\t";
        public static readonly string HOME_QUERY_DELETE = "DELETE NHA WHERE MaNha = @pr1";
        public static readonly string HOME_QUERY_CHECK_EXIST = "SELECT CAST(COUNT(MaNha) as BIT)\r\t" +
                                                               "FROM NHA\r\t" + 
                                                               "WHERE MaNha = @pr1";

        public static readonly string CONTRACT_QUERY_GET_ALL = "SELECT SoHD, TenChuNha, TenKhach, NgayBatDau, NgayKetThuc, DATEDIFF(DAYOFYEAR, NgayBatDau, NgayKetThuc) / 30 * GiaThue as ThanhTien\r\t" +
                                                                "FROM HOPDONG\r\t" +
                                                                "JOIN NHA\r\t" + 
                                                                "ON HOPDONG.MaNha = NHA.MaNha\r\t" + 
                                                                "JOIN KHACHTHUENHA\r\t" +
                                                                "ON HOPDONG.MaKhach = KHACHTHUENHA.MaKhach";
    }
}
