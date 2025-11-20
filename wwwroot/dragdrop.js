window.dragHelper = {
    set: (id) => {
        window.dragItemId = id;
    },
    get: () => {
        return window.dragItemId || "";
    }
};
