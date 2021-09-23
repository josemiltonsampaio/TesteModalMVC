//baseado em https://www.codaffection.com/asp-net-core-article/jquery-ajax-crud-in-asp-net-core-mvc/#Create_MVC_Controller_with_CRUD_Action_Methods

showInPopup = (url, title, campo, funcaoCallback) => {
    //url=url da tela que será chamada
    //title=titulo a ser exibido na tela que será chamada
    //campo=campo (na tela que chamou) que será atualizado com o item selecionado na tela que será chamada
    //funcao=função da tela que chamou, que será disparada após o retorno do valor (ex: um função para pesquisar o código devolvido e preencher o campo descrição)
    $.ajax({
        type: 'GET',
        url: url,
        data: {campo:campo, callback:funcaoCallback},
        success: function (res) {
            $('#form-modal .modal-body').html(res);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
        }
    })
}

//essa função abaixo é para ser usada em caso de utilizar o modal para fazer post (alterar algo)
jQueryAjaxPost = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#view-all').html(res.html)
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('');
                    $('#form-modal').modal('hide');
                }
                else
                    $('#form-modal .modal-body').html(res.html);
            },
            error: function (err) {
                console.log(err)
            }
        })
        //to prevent default form submit event
        return false;
    } catch (ex) {
        console.log(ex)
    }
}