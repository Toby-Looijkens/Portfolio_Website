export class ImageDTO {
  id: string;
  name: string;
  extension: string;
  image: File;

  constructor(id: string, name: string, extension: string, image: File) {
    this.id = id;
    this.name = name;
    this.extension = extension;
    this.image = image;
  }
}