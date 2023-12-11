using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleFours
{
    /// <summary>
    /// THAY ĐỔI MATRIX[X,Y] THÀNH MATRIX[X+2,Y+2],BÀN CỜ THẬT SỰ CHỈ CHẠY TỪ MATRIX[1,1]--->MATRIX[WIDTH,HEIGHT]
    /// I=0,J=0,I=WIDTH+1,J=HEIGHT+1 SẼ CÓ BACKGROUND IMAGE=NULL
    /// </summary>
    class note
    {
        //tạo hàm random->xử lí ăn couple->xử lí thắng thua->xử lí các nút ingame(reset,flycolor) "ok"
        //xử lí thanh lifetime(cho dòng thời gian,các nút help,reset,pause,flycolor) "ok"
        //tạo giao diện & xử lí form menu "ok"
        //xử lí hiệu ứng,âm thanh->nâng cấp thêm tính năng(help) "ok"
        //tester fix bug 


        /// <problem>
        ///xử lí luồng sao cho bớt lag? "ok"
        ///tạo hàm random (xử lí cho nhiều con gần nhau để dễ win,ko thì cho user bấm undo cũng đc) "ok"
        ///xử lí thanh lifetime (processbar hoặc cho *icon di chuyển đếm ngược,*khi dùng trợ giúp sẽ tụt lifetime) "ok"
        ///xử lí thắng thua,ăn couple (score?) "ok"
        ///xử lí hiệu ứng (khi ăn couple pokemon,*hiệu ứng bay màu,win,nút help)
        ///xử lí âm thanh (khi ăn couple pokemon,khi báo hiệu sắp hết giờ,khi tắt/bật âm,*hiệu ứng bay màu)
        ///xử lí các nút ingame (reset(tái lập lại bàn cờ),help,găng tay thanos bay màu nửa bàn cờ,pause) "ok"
        ///tạo giao diện & xử lí form menu (resume,retry,luật chơi,about us,exit) "ok.."
        /// </problem>


        /// <Long>
        /// tạo class tổng quát
        /// xử lí ảnh,tạo giao diện tổng quát
        /// tạo bàn cờ
        /// tạo giao diện & xử lí form menu
        /// xử lí ăn couple
        /// nâng cấp tính năng và fix bug
        /// </Long>



        /// <Phương>
        /// xây dựng ý tưởng nền tảng ăn cờ
        /// xử lí ăn couple
        /// xử lí thắng thua
        /// xử lí thuật toán nút help
        /// </Phương>


        /// <Quân>
        /// xử lí thanh lifetime(cho dòng thời gian,các nút help,reset,pause,flycolor)//tô màu cho thanh
        /// xử lí thuật toán các nút ingame(reset,flycolor)
        /// xử lí âm thanh
        /// </Quân>

    }
}
