// Добавляем эффект появления блоков при прокрутке
document.addEventListener('DOMContentLoaded', () => {
    const sections = document.querySelectorAll('.section');

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('visible');
            }
        });
    }, {
        threshold: 0.2 // Срабатывает, когда 20% элемента видно
    });

    sections.forEach(section => {
        observer.observe(section);
    });
});