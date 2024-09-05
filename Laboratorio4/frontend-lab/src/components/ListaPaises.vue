<!--Para crear esta plantilla se escribe vbase y se da enter-->
<!--En template va el codigo html-->
<template>
    <div class="container mt-5">
        <h1 class="display-4 text-center">Lista de países</h1>
        <table
            class="table is-bordered is-striped is-narrow is-hoverable
            is-fullwidth"
            id="lista">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Continente</th>
                    <th>Idioma</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="(pais, index) of paises" :key="index">
                    <td>{{ pais.nombre }}</td>
                    <td>{{ pais.continente }}</td>
                    <td>{{ pais.Idioma }}</td>
                    <td>
                        <button class="btn btn-secondary btn-sm">Editar</button>
                        <button v-on:click="eliminar(index)" class="btn btn-danger btn-sm">Eliminar</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<!--En script va el codigo javascript-->
<script>
    export default {
        name: "ListaPaises",
        data() {
            return {
                paises: [
                    { nombre: "Costa Rica", continente: "América", Idioma:
                    "Español" },
                    { nombre: "Japón", continente: "Asia", Idioma: "Japonés" },
                    { nombre: "Corea del Sur", continente: "Asia", Idioma:
                    "Coreano" },
                    { nombre: "Italia", continente: "Europa", Idioma: "Italiano" },
                    { nombre: "Alemania", continente: "Europa", Idioma: "Alemán" },
                ],
            };
        },
        methods: {
            eliminar: function(index) {
                this.paises.splice(index, 1);
            }
        },
    };
</script>

<!--En script va el codigo css-->
<style lang="scss" scoped>

</style>