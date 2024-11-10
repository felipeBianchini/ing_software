<template>
    <div><h1>Formulario para crear un pais</h1></div>
    <div class="d-flex justify-content-center align-items-center
vh-100">
        <div class="card p-4 shadow" style="max-width: 400px;
width: 100%">
            <h3 class="text-center">
                Formulario de creacion de
                paises
            </h3>
            <form @submit.prevent="guardarPais">
                <div class="form-group">
                    <label for="nombre">Nombre:</label>
                    <input v-model="datosFormulario.nombre"
                           type="text"
                           id="name"
                           class="form-control"
                           required />
                </div>
                <div class="form-group">
                    <label for="continente">Continente:</label>
                    <select v-model="datosFormulario.continente"
                            id="continente"
                            required
                            class="form-control">
                        <option value="" disabled>
                            Seleccione un
                            continente
                        </option>
                        <option>Africa</option>
                        <option>Asia</option>
                        <option>Europa</option>
                        <option>America</option>
                        <option>Oceania</option>
                        <option>Antartida</option>
                    </select>
                </div>
                <div class="form-group">
                    <label for="idioma">Idioma:</label>
                    <input v-model="datosFormulario.idioma"
                           type="text"
                           id="idioma"
                           class="form-control"
                           required />
                </div>
                <div>
                    <button type="submit" class="btn btn-success btn-block" id="submitButton">
                        Guardar
                    </button>
                </div>
            </form>
        </div>
    </div>
</template>

<script>
    import axios from "axios";
    export default {
        data() {
            return {
                datosFormulario: {
                    nombre: "", continente: "", idioma: "" },
            };
        },
        methods: {
            guardarPais() {
                console.log("Datos a guardar:", this.datosFormulario);
                axios.post("https://localhost:7195/api/Paises", {
                    nombre: this.datosFormulario.nombre,
                    continente: this.datosFormulario.continente,
                    idioma: this.datosFormulario.idioma
                })
                    .then(function (response) {
                        console.log(response);
                        window.location.href = "/";
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
        },
    };
</script>

<style></style>