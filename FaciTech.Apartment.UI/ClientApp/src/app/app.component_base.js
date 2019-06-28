"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var GenericErrorStateMatcher = /** @class */ (function () {
    function GenericErrorStateMatcher() {
    }
    GenericErrorStateMatcher.prototype.isErrorState = function (control, form) {
        var isSubmitted = form && form.submitted;
        return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
    };
    return GenericErrorStateMatcher;
}());
exports.GenericErrorStateMatcher = GenericErrorStateMatcher;
var formRowHeight_Normal = '65px';
var formRowHeight_Tall = '115px';
var FromComponentBase = /** @class */ (function () {
    function FromComponentBase() {
        this.matcher = new GenericErrorStateMatcher();
        this.rowHeight = formRowHeight_Normal;
        this.textAreaHeight = formRowHeight_Tall;
    }
    FromComponentBase.prototype.ngOnInit = function () {
    };
    FromComponentBase.prototype.startLoading = function () {
        this.loading = true;
        this.progress = "query";
    };
    FromComponentBase.prototype.startSaving = function () {
        this.loading = true;
        this.progress = "indeterminate";
    };
    FromComponentBase.prototype.stop = function () {
        this.loading = false;
    };
    return FromComponentBase;
}());
exports.FromComponentBase = FromComponentBase;
"";
//# sourceMappingURL=app.component_base.js.map