window.showNotification = (text, statusCode) => {
    var status = "";
    switch (statusCode) {
        case 0: status = "primary"; break;
        case 1: status = "success"; break;
        case 2: status = "warning"; break;
        case 3: status = "danger"; break;
        default: status = "primary";
    }

    console.log("Show notification: " + text + " / " + status);
    UIkit.notification(text, status);
}