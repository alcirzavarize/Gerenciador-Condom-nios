﻿$(document).ready(function () {
    $("#data").datepicker({
        autoclose: true,
        format: "dd/mm/yyyy",
        defaultDate: new Date(),
        setDefaultDate: true,
        disableWeekends: false,
        showDaysInMextandPreviousMonths: true,
        showMonthAfterYear: true,
        showClearBtn: true,

        i18n: {
            cancel: 'Cancelar',
            clear: 'Limpar',
            done: 'OK',
            previousMonth: '<',
            nextMonths:'>',
            months:[
                'Janeiro',
                'Fevereiro',
                'Marcha',
                'Abril',
                'Maio',
                'Junho',
                'Julho',
                'Agosto',
                'Setembro',
                'Outubro',
                'Novembro',
                'Dezembro'
            ],
                  
            monthsShort:[
                'Jan',
                'Fev',
                'Mar',
                'Abr',
                'Mai',
                'Jun',
                'Jul',
                'Aug',
                'Set',
                'Out',
                'Nov',
                'Dez'
            ],
                  
            weekdays:[
                'Domigo',
                'Segunda-feira',
                'Terça-feira',
                'Quarta-feira',
                'Quinta-feira',
                'Sexta-feira',
                'Sábado'

            ],
            weekdaysShort:[
                'Dom',
                'Seg',
                'Ter',
                'Qua',
                'Qui',
                'Sex',
                'Sab'

            ],
            weekdaysAbbrev:	['D', 'S', 'T', 'Q', 'Q', 'S', 'S'],
        }
    });
})