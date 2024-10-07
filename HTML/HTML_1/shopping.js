function additem() 
{
    const input = document.getElementById("input_item");
    const itemText = input.value.trim();
    const itemlist=document.getElementById("item_list");
    const li=document.createElement("li");
    li.textContent=itemText;

    const deletebutton=document.createElement("button");
    deletebutton.textContent="delete";

    deletebutton.onclick=()=>li.remove();

    li.appendChild(deletebutton);
    itemlist.appendChild(li);

    input.value=" ";
    input.focus();

};