%Truyền vào 2 tham số: 1 loại quan tâm, 2 giá tiền
%kết quả trả về là 1 hoặc tập hợp laptop X thỏa mãn 2 tham số
%Dữ liệu gồm danh sách các laptop thời trang trong 2 tầm giá
%danh sách laptop có cấu hình tốt nhất trong 2 tầm giá
%danh sách laptop có giá cả hợp lý trong tầm giá
%danh sách theo hãng
%nếu có quan tâm hãng thì truy vấn hãng và loại quan tâm và giá tiền
%nếu ko chỉ quan tâm loại và giá tiền
% dell-1, hp-2,lenovo-3,asus-4,acer-5
% price - 1, fashion-2, specs-3
% low -1, high-2
brand(dell,[121]).
brand(dell,[122]).
brand(dell,[131]).
brand(dell,[132]).
brand(dell,[111]).
brand(dell,[112]).

brand(hp,[221]).
brand(hp,[222]).
brand(hp,[231]).
brand(hp,[232]).
brand(hp,[211]).
brand(hp,[212]).

brand(lenovo,[321]).
brand(lenovo,[321]).
brand(lenovo,[322]).
brand(lenovo,[331]).
brand(lenovo,[332]).
brand(lenovo,[311]).
brand(lenovo,[312]).

brand(asus,[421]). 
brand(asus,[422]). 
brand(asus,[431]). 
brand(asus,[432]). 
brand(asus,[411]). 
brand(asus,[412]). 

brand(acer,[521]). 
brand(acer,[522]). 
brand(acer,[531]). 
brand(acer,[511]). 
brand(acer,[512]). 

type(price,[111]).
type(price,[112]).
type(price,[211]).
type(price,[212]).
type(price,[311]).
type(price,[312]).
type(price,[411]).
type(price,[412]).
type(price,[511]).
type(price,[512]).
type(fashion,[121]).
type(fashion,[122]).
type(fashion,[221]).
type(fashion,[222]).
type(fashion,[321]).
type(fashion,[322]).
type(fashion,[421]).
type(fashion,[422]).
type(fashion,[521]).
type(fashion,[522]).
type(specs,[131]).
type(specs,[132]).
type(specs,[231]).
type(specs,[232]).
type(specs,[331]).
type(specs,[332]).
type(specs,[431]).
type(specs,[432]).
type(specs,[531]).
type(specs,[532]).

price(low,[111]).
price(low,[121]).
price(low,[131]).
price(low,[211]).
price(low,[221]).
price(low,[231]).
price(low,[311]).
price(low,[321]).
price(low,[331]).
price(low,[411]).
price(low,[421]).
price(low,[431]).
price(low,[511]).
price(low,[521]).
price(low,[531]).
price(high,[112]).
price(high,[122]).
price(high,[132]).
price(high,[212]).
price(high,[222]).
price(high,[232]).
price(high,[312]).
price(high,[322]).
price(high,[332]).
price(high,[412]).
price(high,[422]).
price(high,[432]).
price(high,[512]).
price(high,[522]).
price(high,[532]).

laptop(BRAND,TYPE,PRICE,X):-brand(BRAND,X),type(TYPE,X), price(PRICE,X).
laptop(TYPE,PRICE,X):-type(TYPE,X), price(PRICE,X).

