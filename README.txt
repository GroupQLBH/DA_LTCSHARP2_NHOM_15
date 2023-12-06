# Đồ án quản lý bán hàng 
# Các thành viên nhóm:
    -Nguyễn Quang Vinh - 2001206911
    -Vương Đức Khánh - 2001207096
    -Nguyễn Phạm Hoàng Khang - 2001206933
 CHƯƠNG 1.	TỔNG QUAN
1.1.Định nghĩa vấn đề
Trong xu thế công nghệ số phát triển mạnh mẽ, hình thức kinh doanh trực tuyến ngày càng phổ biến. Theo thống kê, doanh số bán lẻ trực tuyến tại Việt Nam tăng trưởng 30-50% mỗi năm. Điều này cho thấy nhu cầu mua sắm trực tuyến ngày càng lớn. Tuy nhiên, nhiều doanh nghiệp Việt Nam vẫn chưa khai thác triệt để kênh bán hàng online. Hệ thống quản lý bán hàng còn thủ công, dữ liệu phân tán gây khó khăn cho việc mở rộng kinh doanh.
Bên cạnh đó, xu hướng ứng dụng trí tuệ nhân tạo vào hoạt động kinh doanh ngày càng phổ biến. Theo nghiên cứu của Gartner, đến năm 2022, 85% doanh nghiệp sử dụng AI để tối ưu hóa trải nghiệm khách hàng. Tuy nhiên, nhiều doanh nghiệp Việt chưa tận dụng được các công nghệ AI tiên tiến để phân tích dữ liệu khách hàng và đưa ra các đề xuất, dự đoán nhằm tăng doanh số bán hàng.
Chính vì vậy, việc xây dựng một hệ thống quản lý bán hàng đa kênh, tích hợp trí tuệ nhân tạo sẽ giúp doanh nghiệp tối ưu hóa hoạt động kinh doanh, mở rộng thị phần và nâng cao lợi nhuận. Đây chính là vấn đề mà đề tài nhắm tới giải quyết.
1.2.Phạm vi đồ án
Đề tài tập trung xây dựng hệ thống quản lý bán laptop đa kênh cho một doanh nghiệp kinh doanh laptop tại thị trường Việt Nam. Hệ thống sẽ bao gồm các module chính sau:
Website bán hàng trực tuyến: Cho phép khách hàng mua sắm các sản phẩm laptop trực tuyến thông qua website. Website được thiết kế thân thiện, thuận tiện cho người dùng.
Ứng dụng quản lý bán hàng tại cửa hàng: Giúp quản lý các hoạt động bán hàng tại cửa hàng như lập hóa đơn, xem số hàng tồn kho, thống kê doanh số...
Hệ thống đề xuất sản phẩm: Sử dụng thuật toán AI để phân tích dữ liệu khách hàng và đưa ra gợi ý các sản phẩm laptop phù hợp khác mà khách hàng có thể quan tâm.
Cơ sở dữ liệu: Lưu trữ thông tin sản phẩm, khách hàng, đơn hàng, kho... trên hệ quản trị CSDL SQL Server.
Như vậy, phạm vi đề tài tập trung vào việc phân tích, thiết kế và xây dựng các module then chốt của hệ thống quản lý bán laptop đa kênh cho doanh nghiệp.
1.3.Mục tiêu, sự cần thiết của đề tài, tại sao lại chọn đề tài này?
Mục tiêu chính của đề tài là xây dựng hệ thống quản lý bán laptop đa kênh, tích hợp trí tuệ nhân tạo để hỗ trợ đề xuất sản phẩm nhằm nâng cao hiệu quả hoạt động kinh doanh cho doanh nghiệp. Cụ thể, đề tài hướng tới các mục tiêu:
Tối ưu hóa quy trình bán hàng online và tại cửa hàng.
Mở rộng khả năng tiếp cận khách hàng thông qua kênh bán hàng trực tuyến
Áp dụng công nghệ trí tuệ nhân tạo để phân tích dữ liệu và đề xuất sản phẩm nhằm tăng doanh số.
Quản lý tập trung dữ liệu sản phẩm, khách hàng, đơn hàng, tồn kho... thông qua hệ thống
Nâng cao trải nghiệm và sự hài lòng của khách hàng.
Đề tài mang tính cấp thiết và cần thiết vì:
-	Giúp doanh nghiệp đáp ứng xu thế phát triển của thương mại điện tử
-	Giúp khai thác hiệu quả kênh bán hàng trực tuyến đang phát triển mạnh
-	Áp dụng công nghệ AI vào hoạt động kinh doanh  
-	Xu hướng tất yếu giảm chi phí vận hành nhờ quản lý đơn giản, khoa học và tập trung
-	Nâng cao năng lực cạnh tranh của doanh nghiệp trên thị trường
Lý do chọn đề tài:
-	Đề tài thiết thực, phù hợp xu thế phát triển hiện tại
-	Vận dụng tốt kiến thức đã học vào giải quyết vấn đề thực tiễn
-	Đề tài thử thách về mặt kỹ thuật, đòi hỏi kỹ năng lập trình và thiết kế
-	Nhóm thực hiện đề tài có đủ năng lực và kinh nghiệm
Như vậy, với những điểm mạnh nêu trên, đây chính là đề tài phù hợp và có giá trị thực tiễn cao. Việc thực hiện thành công đề tài sẽ góp phần nâng cao năng lực cho cả nhóm thực hiện.

 
CHƯƠNG 2.	PHÂN TÍCH VÀ THIẾT KẾ
2.1.Phân tích yêu cầu hệ thống, quy trình nghiệp vụ
2.1.1.Yêu cầu hệ thống
Giao Diện Người Dùng (UI)
Giao diện Application quản lý bao gồm Đăng nhập có phân quyền với nhân viên bình thường chỉ có thể quản lý khách hàng và bán hàng còn với nhân viên cấp cao như quản lý sẽ có toàn quyền trên hệ thống và Dardboard chính gồm các chức năng  :
-	Quản lý nhân viên: Thêm, xóa, sửa nhân viên và tạo tài khoản cho nhân viên đó
-	Quản lý nhóm người dùng: Thêm, xóa, sửa nhóm người dùng và việc thêm hoặc xóa người dùng khỏi nhóm người dùng.
-	Quản lý hiển thị và phân quyền: Thêm, xóa, sửa màn hình, Thêm, xóa, sửa phân quyền.
-	Quản lý khách hàng: Thêm, xóa, sửa khách hàng.
-	Quản lý loại sản phẩm: Thêm, xóa, sửa loại sản phẩm.
-	Quản lý thương hiệu: Thêm, xóa, sửa thương hiệu.
-	Quản lý sản phẩm: Thêm, xóa, sửa sản phẩm.
-	Quản lý nhà cung cấp: Thêm, xóa, sửa nhà cung cấp.
-	Quản lý kho: Thêm, xóa, sửa kho.
-	Quản lý bán hàng: Thêm một hóa đơn mới, thanh toán hóa đơn, in hóa đơn
-	Quản lý nhập hàng: Cho phép nhân viên tạo phiếu nhập hàng, chọn nhà cung cấp, nhập thông tin các sản phẩm nhập. 
-	Thống kê báo cáo: Thống kê doanh số bán hàng theo thời gian (ngày/tuần/tháng/quý/năm), thống kê sản phẩm bán chạy/tồn kho nhiều
Quản Lý Dữ Liệu
-	Sử dụng CSDL SQL Server để lưu trữ dữ liệu
-	Thiết kế các bảng dữ liệu: nhân viên, khách hàng, sản phẩm, đơn hàng, chi tiết đơn hàng, kho, nhà cung cấp,...
-	Quản lý mối quan hệ giữa các bảng thông qua khóa ngoại (foreign key)
-	Sao lưu dữ liệu thường xuyên để đảm bảo an toàn.
Tích Hợp Thứ Bậc
AI gợi ý sản phẩm mua kèm
Kết Nối Database
Dùng linq và dataset cho việc kết nối cơ sở dữ liệu, với việc dataset hỗ trợ khá mạnh về mảng giao diện và linq trong mảng đa xử lý sẽ giúp cho hệ thống hoạt động tốt hơn và giúp đẩy nhanh tiến độ công việc hơn.
2.1.2.Quy Trình Nghiệp Vụ
Quy trình bán hàng tại quầy giao dịch 
Bước 1 :Khách hàng đặt hàng trực tiếp tại cửa hàng hoặc qua website
Bước 2: Nhân viên kiểm tra tồn kho và tạo hóa đơn bán hàng
Bước 3: Nhân viên cập nhật số lượng sản phẩm trong kho
Bước 4: Khách thanh toán và nhận hàng
Bước 5: Lưu thông tin khách hàng và lịch sử mua hàng vào hệ thống
Quy trình nhập hàng
Bước 1: Kiểm tra và xác định nhu cầu nhập hàng
Bước 2: Lên kế hoạch và đặt hàng với nhà cung cấp
Bước 3: Nhận hàng và kiểm tra chất lượng
Bước 4: Cập nhật số lượng hàng nhập kho vào hệ thống
Bước 5: Xử lý hàng lỗi, hỏng, thừa, thiếu (nếu có)
Quy trình thống kê và báo cáo
-	Thống kê doanh số bán hàng theo ngày/tuần/tháng/quý/năm
-	Báo cáo tồn kho các sản phẩm
-	Báo cáo tổng quan tình hình kinh doanh của công ty
Quy trình bán hàng online tại website
Bước 1: Khách hàng truy cập vào website
Bước 2: Khách hàng xem các sản phẩm và lựa chọn sản phẩm mong muốn
Bước 3: Khách hàng thêm sản phẩm vào giỏ hàng
Bước 4: Khách hàng xem giỏ hàng, cập nhật số lượng và áp dụng mã giảm giá (nếu có)
Bước 5: Khách hàng nhập thông tin giao hàng và thông tin thanh toán
Bước 6: Khách hàng xác nhận đơn hàng
Bước 7: Hệ thống cập nhật trạng thái đơn hàng
Bước 8: Nhân viên kinh doanh xử lý và giao hàng cho khách
2.2.Yêu cầu chức năng
2.2.1.Website
Giao diện trang web bán hàng: gồm các trang Home, Giới thiệu, Sản phẩm, Tin tức, Liên hệ, Giỏ hàng, Thanh toán,...Cho phép khách hàng tạo tài khoản đăng nhập vào website thao tác các chức năng như mua hàng, thanh toán, xem danh sách sản phẩm,..
2.2.2.WindowsFormsApp
Giao diện ứng dụng quản lý:
-	Giao diện đăng nhập với phân quyền người dùng
-	Giao diện chính gồm menu dọc bên trái và nội dung hiển thị phần lớn màn hình
-	Các giao diện chức năng chính: Quản lý đơn hàng, Quản lý sản phẩm, Quản lý khách hàng, Quản lý kho, Báo cáo thống kê, Quản lý danh mục, Quản lý tài khoản,...
Luồng chức năng chính:
-	Đăng nhập - Xác thực người dùng
-	Quản lý đơn hàng - Cho phép thêm/sửa/xóa đơn hàng, in hóa đơn
-	Quản lý sản phẩm - Cho phép thêm/sửa/xóa sản phẩm
-	Quản lý khách hàng - Cho phép thêm/sửa/xóa khách hàng
-	Quản lý kho - Cho phép nhập/xuất/kiểm kê kho
-	Báo cáo doanh số - Thống kê và xem báo cáo doanh số theo nhiều tiêu chí
2.2.3.AI 
-	Gợi ý sản phẩm mua kèm: Gợi ý các sản phẩm bổ trợ, phụ kiện hoặc các sản phẩm liên quan cho khách hàng dựa trên sản phẩm khách đang xem hoặc đã chọn mua.
-	Khách hàng truy cập vào chi tiết sản phẩm.
-	Hệ thống thu thập thông tin về sản phẩm khách hàng đang xem.
-	Hệ thống áp dụng thuật toán Machine Learning để phân tích và dự đoán các sản phẩm liên quan mà khách hàng có thể quan tâm.
-	Hệ thống hiển thị danh sách các sản phẩm được gợi ý phù hợp với khách hàng.
-	Khách hàng có thể xem các sản phẩm gợi ý và tiếp tục mua hàng.
