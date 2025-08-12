import { Tag } from "./Tag";
import { ImageDTO } from "./ImageDTO";

export class galleryItem {
  id: string;
  title: string;
  description: string;
  thumbnail: File;
  images: ImageDTO[]
  tags: Tag[];

  constructor(id: string, title: string, description: string, thumbail: File, images: ImageDTO[], tags: Tag[]) {
    this.id = id;
    this.title = title;
    this.description = description;
    this.thumbnail = thumbail;
    this.images = images
    this.tags = tags
  }
}