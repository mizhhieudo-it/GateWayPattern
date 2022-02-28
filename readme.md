# GateWay Pattern là gì ? 
### GateWay là một cổng trung gian , GateWay nhận request và điều hướng Request tới các service trong hệ thống 
## Hình ảnh minh họa nếu sử dụng GateWay 
![This is an image](images/example.png)
## Hình ảnh minh họa nếu không sử dụng GateWay
![This is an image](images/non-using-gateway.png)
## Nhiệm vụ chính của GateWay : 
	- Routing : Quản lý các dịch vụ và phân phối request từ client đến dịch vụ tương ứng.
	- Offloading : Cung cấp khả năng giảm tải thôngqua cung cấp các cross-cutting function sử dung chung bởi các microservices.
## Lợi ích của GateWay :
	- Che dấu được đi cấu trúc của hệ thống micro Service
	- Bên ngoài chỉ cần chọc vào GateWay  

