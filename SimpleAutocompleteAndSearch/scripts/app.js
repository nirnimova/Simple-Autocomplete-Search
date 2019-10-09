$(function () {
    // Init UI
    const ui = new UI($);
    const jobAPI = new JobAPI;

    const searchJobBtn = document.getElementById('searchJobBtn');

    searchJobBtn.addEventListener('click', () => {
        // Clear results
        ui.clearResults();

        // Get input text
        const searchJob = document.getElementById('searchJob');
        const jobText = searchJob.value;
        if (jobText !== '') {
            jobAPI.searchJobsByTitle(jobText).then(res => {
                ui.fillResults(res.jobs.Data);
            })
        }
    }); 

    ui.autocomplete('searchJob');
});

