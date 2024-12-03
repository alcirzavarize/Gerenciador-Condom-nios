function MontarGraficoLinhasGanhos(ano) {
    $.ajax({
        url: '/Dashboard/DadosGraficoGanhos',
        method: 'GET',
        data: { ano: ano },
        success: function (dados) {
            new Chart(document.getElementById("GraficoValoresGanhosDespesas"), {
                type: 'line',

                data: {
                    labels: PegarMeses(dados),
                    datasets: [{
                        label: "Ganhos com pagamentos por ano",
                        data: PegarValores(dados),
                        backgroudColor: "#90caf9",
                        borderColor: "#0277bd",
                        fill: true,
                        lineTension: 0
                    }]
                },

                options: {
                    legend: {
                        labels: {
                            usePointStyle: true
                        }
                    },

                    scales: {
                        xAxes: [{
                            gridLines: {
                                display: false
                            }
                        }]
                    }
                }
            });
        }
    });
}

function MontarGraficoLinhasDespesas(ano) {
    $.ajax({
        url: '/Dashboard/DadosGraficoDespesas',
        method: 'GET',
        data: { ano: ano },
        success: function (dados) {
            new Chart(document.getElementById("GraficoValoresGanhosDespesas"), {
                type: 'line',

                data: {
                    labels: PegarMeses(dados),
                    datasets: [{
                        label: "Despesas com serviços por ano",
                        data: PegarValores(dados),
                        backgroudColor: "#ffcdd2",
                        borderColor: "#b71c1c",
                        fill: true,
                        lineTension: 0
                    }]
                },

                options: {
                    legend: {
                        labels: {
                            usePointStyle: true
                        }
                    },

                    scales: {
                        xAxes: [{
                            gridLines: {
                                display: false
                            }
                        }]
                    }
                }
            });
        }
    });
}

function MontarGraficoDespesasGanhosTotais() {
    $.ajax({
        url: '/Dashboard/DadosGraficoDespesasGanhosTotais',
        method: 'GET',
        success: function (dados) {
            new Chart(document.getElementById("GraficoDespesasGanhosTotais"), {

                type: 'pie',

                data: {
                    labels: ["Ganhos", "Despesas"],

                    datasets: [{
                        label: "Total de Ganhos e despesas",
                        data: [dados.ganhos, dados.despesas],
                        backgroundColor: ["#0091ea","#c62828"]
                    }]
                },

                options: {
                    legend: {
                        labels: {
                            usePointStyle: true
                        }
                    }
                }
            });
        }
    });
}