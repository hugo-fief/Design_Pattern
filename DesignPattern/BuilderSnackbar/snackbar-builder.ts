class SnackbarBuilder {
    message: string;
    title: string;
    isSticky: boolean;
    type: string;
    icon: string;
    canClose: boolean;
    duration: number;

    constructor(message: string) {
        this.message = message;
    }

    setTitle(title: string) {
        this.title = title;
        return this;
    }

    setSticky(isSticky: boolean) {
        this.isSticky = isSticky;
        return this;
    }

    private setType(type: string) {
        this.type = type;
        return this;
    }

    private setIcon(icon: string) {
        this.icon = icon;
        return this;
    }

    private setCanClose(canClose: boolean) {
        this.canClose = canClose;
        return this;
    }

    private setDuration(duration: number) {
        this.duration = duration;
        return this;
    }

    buildSuccess() {
        this.setType('success');
        this.setDuration(3000);
        this.setCanClose(false);
        return this.build();
    }

    buildInfo() {
        this.setType('information');
        this.setDuration(3000);
        this.setCanClose(false);
        return this.build();
    }

    buildWarning() {
        this.setType('warning');
        this.setCanClose(true);
        return this.build();
    }

    buildError() {
        this.setType('error');
        this.setCanClose(true);
        return this.build();
    }

    private build() {
        return new snackbar(
            this.message,
            this.title,
            this.isSticky,
            this.type,
            this.icon,
            this.canClose,
            this.duration
        );
    }
}

// Use case //
const message = 'This is a sample message';
const snackbar = new SnackbarBuilder(message).setSticky(true).buildInfo();
