import { ToastOptions } from 'ng2-toastr';

export class ToastConfig extends ToastOptions {
  animate = 'flyRight'; // you can override any options available
  positionClass = 'toast-top-center';
  showCloseButton: true;
};

// Use a exported function like this.
// Important: All keys should be defined to match the type ToastOptions.
// export function ToastConfig(): ToastOptions {
//     return {
//         toastLife: 5000,
//         dismiss: 'auto',
//         showCloseButton: true,
//         positionClass : 'toast-top-center',
//         animate : 'flyRight',
//         maxShown: 5,
//         newestOnTop: true,
//         enableHTML: true,
//         messageClass: '',
//         titleClass: ''
//     };
// }