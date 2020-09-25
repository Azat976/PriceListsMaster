function newField() {
    // ���������� ��������� ��� �������� ����� � ���������
    let container = document.getElementById("questions");
    // �������� ������� ���������� input (����� ��� ��������)
    let fieldCount = container.getElementsByTagName("input").length;
    // ����������� Id ��� ������ ����
    let nextFieldId = fieldCount + 1;

    // ����� ��������� �������, ������� ����� ������� input (� ���� ������, � ��� ����� ���� �� ������� ��� ������ �� ���� ���)
    let div = document.createElement("div");
    div.setAttribute("class", "form-group");

    // ������� ����� ���� � ����� id, name ������ ��������� � ������ ���� � ������!!!
    let field = document.createElement("input");
    field.setAttribute("class", "form-control");
    field.setAttribute("id", "Questions[" + nextFieldId + "]");
    field.setAttribute("name", "Questions");
    field.setAttribute("type", "text");
    field.setAttribute("placeholder", "������� ����� �������");

    // ��������� ���� � <div class="form-group"></div>
    div.appendChild(field);
    // ��������� <div class="form-group"><input ... /></div> � ������� ���������
    container.appendChild(div);
}