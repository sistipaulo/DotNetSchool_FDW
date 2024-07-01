// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))


const toastTrigger = document.getElementById('liveToastBtn')
const toastLiveExample = document.getElementById('liveToast')

if (toastTrigger) {
    const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample)
    toastTrigger.addEventListener('click', () => {
        toastBootstrap.show()
    })
}


$(document).ready(function () {
    // Exemplo com links
    $('a').on('click', function (event) {
        event.preventDefault(); // Prevenir o comportamento padrão do link

        var url = $(this).attr('href'); // Obter a URL do link clicado

        $('#overlay').fadeIn();
        $('#loader').show(); // Mostrar o loader

        // Simular atraso de carregamento com setTimeout (você pode substituir isso pelo carregamento real)
        setTimeout(function () {
            window.location.href = url; // Redirecionar para a nova página após um certo tempo
        }, 2000); // Tempo de simulação de 1 segundo (1000 milissegundos)
    });
});
