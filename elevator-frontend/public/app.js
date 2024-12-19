// URL de la API Backend
const apiUrl = 'http://localhost:5287/api/elevator';


function callElevator() {
    const floor = document.getElementById('floor').value;
    fetch(`${apiUrl}/call`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ floorNumber: floor, isProcessed: false })
    })
        .then(response => response.json())
        .then(data => alert('Ascensor llamado al piso ' + floor))
        .catch(error => console.error('Error al llamar al ascensor:', error));
}


function startElevator() {
    fetch(`${apiUrl}/start`, {
        method: 'POST',
    })
        .then(response => response.json())
        .then(data => alert('Ascensor iniciado'))
        .catch(error => console.error('Error al iniciar el ascensor:', error));
}


function stopElevator() {
    fetch(`${apiUrl}/stop`, {
        method: 'POST',
    })
        .then(response => response.json())
        .then(data => alert('Ascensor detenido'))
        .catch(error => console.error('Error al detener el ascensor:', error));
}


function openDoors() {
    fetch(`${apiUrl}/open-doors`, {
        method: 'POST',
    })
        .then(response => response.json())
        .then(data => alert('Puertas abiertas'))
        .catch(error => console.error('Error al abrir las puertas:', error));
}


function closeDoors() {
    fetch(`${apiUrl}/close-doors`, {
        method: 'POST',
    })
        .then(response => response.json())
        .then(data => alert('Puertas cerradas'))
        .catch(error => console.error('Error al cerrar las puertas:', error));
}
