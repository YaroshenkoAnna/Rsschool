:root {
  --Primary: #ff4646;
  --Primary-10: rgba(255, 70, 70, 0.1);
  --Dark: #181c29;
  --Static-White: #fff;
  --Static-White-40: rgba(255, 255, 255, 0.4);
  --Static-White-20: rgba(255, 255, 255, 0.2);
  --Tag-Purple: #4361ff;
  --Tag-Pink: #ff43f7;
  --Tag-Green: #06a44f;
}

@font-face {
  font-family: "Montserrat";
  src: url("../fonts/Montserrat-VariableFont_wght.ttf");
}
@font-face {
  font-family: "Allura";
  src: url("../fonts/Allura-Regular.ttf");
}
.container {
  border-radius: 20px;
  overflow: hidden;
  background-color: var(--Primary);
}

.card {
  max-width: 310px;
  display: flex;
  flex-direction: column;
  border-radius: 20px;
  background-color: #ecf3f8;
  color: var(--Dark);
  cursor: pointer;
}
.card_modal {
  cursor: default;
  max-width: 400px;
}
.card_modal .card__container {
  height: auto;
}
.card__image {
  width: 310px;
  height: 230px;
}
.card__image_modal {
  position: relative;
  object-fit: cover;
  width: 100%;
}
.card__container {
  width: 100%;
  box-sizing: border-box;
  height: 112px;
  display: flex;
  flex-direction: column;
  gap: 8px;
}
.card__container_horizontal {
  width: auto;
  justify-content: space-between;
  flex-direction: row;
}
.card__container_horizontal12 {
  align-items: center;
  width: 100%;
  flex-direction: row;
  gap: 12px;
}
.card__category {
  font-size: 12px;
  line-height: 130%; /* 15.6px */
  letter-spacing: 0.6px;
  text-transform: uppercase;
}
.card__category_work {
  color: var(--Tag-Purple);
}
.card__category_harmony {
  color: var(--Tag-Pink);
}
.card__category_health {
  color: var(--Tag-Green);
}
.card__title {
  font-size: 16px;
  line-height: 152%; /* 24.32px */
  letter-spacing: 1.28px;
  text-transform: uppercase;
}
.card__description {
  font-size: 16px;
  font-weight: 400;
  line-height: 148%;
}
.card__description_gr {
  flex-grow: 1;
}
.card__wraper {
  border-radius: 20px;
  padding: 20px;
  background-color: var(--Static-White);
  display: flex;
  flex-direction: column;
  gap: 20px;
}
.card__cross {
  position: absolute;
  width: 40px;
  height: 40px;
  display: flex;
}
.card__line {
  background-color: var(--Dark);
  width: 1px;
  height: 20px;
}
.card__line:first-child {
  transform: rotate(45deg);
}
.card__line:last-child {
  transform: rotate(-45deg);
}

@media (hover: hover) and (pointer: fine) {
  .card:hover .card__title {
    color: var(--Primary);
  }
  .card_modal:hover .card__title {
    color: var(--Dark);
  }
}
.footer {
  background-color: var(--Static-White);
  display: flex;
  align-items: center;
  flex-direction: column;
  gap: 60px;
  padding: 60px clamp(8px, 8.929vw - 60.578px, 68px);
  color: var(--Dark);
}
.footer__content {
  display: flex;
  flex-wrap: wrap;
  gap: 12px;
}
.footer__wraper {
  display: flex;
  flex-direction: column;
  gap: 12px;
  text-align: center;
  align-items: center;
}
.footer__link {
  display: flex;
  flex-direction: column;
  gap: 12px;
  text-align: center;
  align-items: center;
  background-color: #ecf3f8;
  border-radius: 20px;
  min-width: 377px;
  box-sizing: border-box;
  padding: 20px;
  text-decoration: none;
  color: inherit;
  transition: color 0.4s ease-in;
}
.footer__link:active {
  color: var(--Primary);
}
.footer__image {
  width: 80px;
  height: 80px;
}
.footer__title {
  font-size: 24px;
  line-height: 152%; /* 36.48px */
  letter-spacing: 3.84px;
  text-transform: uppercase;
}
.footer__description {
  font-size: 16px;
  line-height: 152%; /* 24.32px */
  letter-spacing: 1.28px;
  text-transform: uppercase;
}
.footer__icon {
  cursor: pointer;
  padding: 8px;
}
.footer__icon svg {
  transition: stroke 0.4s ease-in;
  width: 24px;
  height: 24px;
  stroke: var(--Dark);
}
.footer__text {
  font-size: 16px;
  font-weight: 400;
  line-height: 148%;
}
.footer__caption {
  font-family: Allura;
  font-size: 24px;
  font-weight: 400;
  line-height: 100%; /* 24px */
  letter-spacing: 1.2px;
  color: inherit;
}
.footer__link-caption {
  text-decoration: none;
  color: inherit;
  transition: color 0.4s ease-in;
}
.footer__link-caption:active {
  color: var(--Primary);
}

@media (hover: hover) and (pointer: fine) {
  .footer__link:hover {
    cursor: pointer;
    color: var(--Primary);
  }
  .footer__icon:hover svg {
    stroke: var(--Primary);
  }
  .footer__link-caption:hover {
    color: var(--Primary);
  }
}
@media only screen and (max-width: 1258px) {
  .footer__wraper,
  .footer__link {
    width: 100%;
  }
}
.header {
  padding: 12px clamp(8px, 11.012vw - 76.573px, 82px);
  background-color: var(--Static-White);
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  font-size: 12px;
  line-height: 130%;
  letter-spacing: 5%;
  text-transform: uppercase;
  color: var(--Dark);
}
.header__logo {
  padding: 8px 20px;
  display: flex;
  gap: 8px;
  align-items: center;
  text-decoration: none;
  color: inherit;
}
.header__logo-image {
  width: 24px;
  height: 24px;
}

.navigation__list {
  display: flex;
  flex-direction: row;
  gap: 8px;
}
.navigation__item {
  padding: 12px 20px;
  border-radius: 12px;
  list-style: none;
  transition: all 0.4s ease-in;
}
.navigation__item_active {
  pointer-events: none;
  background-color: var(--Primary-10);
  color: var(--Primary);
}
.navigation__item :active {
  background-color: var(--Primary-10);
  color: var(--Primary);
}
.navigation__link {
  text-decoration: none;
  color: inherit;
}

@media (hover: hover) and (pointer: fine) {
  .navigation__item:hover {
    cursor: pointer;
    background-color: var(--Primary-10);
    color: var(--Primary);
  }
}
@media only screen and (max-width: 768px) {
  .navigation {
    z-index: 100;
    width: 100vw;
    height: 100vh;
    position: fixed;
    overflow-y: auto;
    background-color: var(--Static-White);
    transition: right 0.5s ease-in;
    top: 62px;
    right: -100vw;
  }
  .navigation__list {
    height: calc(100% - 56px);
    justify-content: center;
    align-items: center;
    flex-direction: column;
  }
  .navigation_active {
    right: 0;
  }
}
.page {
  max-width: 1440px;
  font-family: "Montserrat";
  font-style: normal;
  font-weight: 600;
  color: var(--Static-White);
  margin: auto;
}

.enabled-scroll {
  overflow: hidden;
}

.section {
  background-image: url("../images/bg-snow.png");
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
  padding: 60px clamp(8px, 8.929vw - 60.578px, 68px);
}
.section_hero {
  background-image: url("../images/bg-ball.png"), url("../images/bg-snow.png");
  height: 524px;
  box-sizing: border-box;
}
.section_about {
  color: var(--Dark);
}
.section_cta {
  background-image: url("../images/bg-forest.png"), url("../images/bg-snow.png");
}
.section_cta .section__content {
  text-align: center;
}
.section_gifts {
  background-image: url("../images/bg-garland.png");
  background-position: top;
  background-size: contain;
}
.section__content {
  margin: auto;
  align-items: center;
  display: flex;
  flex-direction: column;
  gap: 20px;
}
.section__content_sm-gap {
  gap: 12px;
}
.section__content_padding60 {
  padding: 60px 0;
}
.section__caption {
  font-family: "Allura";
  font-size: 24px;
  font-weight: 400;
  line-height: 100%; /* 24px */
  letter-spacing: 1.2px;
}
.section__caption_primary {
  align-self: flex-start;
  color: var(--Primary);
}
.section__title {
  max-width: 426px;
  font-size: 24px;
  line-height: 152%; /* 36.48px */
  letter-spacing: 3.84px;
  text-transform: uppercase;
}
.section__title_main {
  text-align: center;
  font-size: 32px;
  line-height: 150%;
  letter-spacing: 5.76px;
}
.section__button {
  padding: 20px 32px;
  background-color: var(--Dark);
  font-size: 12px;
  line-height: 130%; /* 15.6px */
  letter-spacing: 0.6px;
  text-transform: uppercase;
  border-radius: 20px;
  color: var(--Static-White);
  transition: all 0.4s ease-in;
}
.section__button:active {
  background-color: var(--Static-White);
  color: var(--Dark);
}
.section__wraper {
  border-radius: 20px;
  display: flex;
  justify-content: space-between;
  background-color: var(--Static-White);
  overflow: hidden;
}
.section__content-wraper {
  background-color: var(--Static-White);
  padding: 0 60px;
  display: flex;
  align-items: center;
}
.section__description {
  font-size: 16px;
  font-weight: 400;
  line-height: 148%;
  max-width: 426px;
}
.section__image {
  border-radius: 20px;
}
.section__title-wraper {
  display: flex;
  justify-content: center;
  gap: 12px;
}
.section__slider {
  align-self: flex-start;
}
.section__gallery {
  display: flex;
  justify-content: center;
  gap: 12px;
  flex-wrap: wrap;
  max-width: 1276px;
}
.section__switches {
  display: flex;
  flex-direction: row;
}
.section__switch {
  padding: 12px 20px;
  border-radius: 12px;
  font-size: 12px;
  line-height: 130%; /* 15.6px */
  letter-spacing: 0.6px;
  text-transform: uppercase;
}
.section__switch_active {
  pointer-events: none;
  background-color: var(--Static-White-20);
}
.section__switch:active {
  background-color: var(--Static-White-20);
}

@media only screen and (max-width: 1439px) {
  .section__gallery {
    max-width: 632px;
  }
}
@media only screen and (max-width: 468px) {
  .section__switch {
    padding: 12px 8px;
  }
}
@media (hover: hover) and (pointer: fine) {
  .section__button:hover {
    cursor: pointer;
    background-color: var(--Static-White);
    color: var(--Dark);
  }
  .section__switch:hover {
    cursor: pointer;
    background-color: var(--Static-White-20);
  }
}
.slider__wraper {
  display: flex;
  flex-direction: row;
  align-items: center;
  gap: 20px;
  align-self: flex-start;
}
.slider__text {
  font-size: 80px;
  line-height: normal;
  text-transform: uppercase;
}
.slider__image {
  width: 200px;
  height: 200px;
  border-radius: 20px;
}
.slider__arrows {
  position: relative;
  left: clamp(5px, 100vw - (8.929vw - 60.578px) * 2 - 132px, 1162px);
  margin-top: 20px;
  display: inline-flex;
  flex-direction: row;
  gap: 20px;
  align-self: flex-end;
}
.slider__arrow {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 56px;
  height: 56px;
  border-radius: 20px;
  stroke: var(--Static-White);
  border: 1px solid var(--Static-White);
  transition: all 0.4s ease-in;
}
.slider__arrow:active {
  background-color: var(--Static-White);
  stroke: var(--Primary);
}
.slider__arrow_inactive {
  pointer-events: none;
  stroke: var(--Static-White-40);
  border-color: var(--Static-White-40);
}
.slider__arrow svg {
  stroke: inherit;
}

@media only screen and (max-width: 768px) {
  .slider__arrows {
    left: clamp(5px, 100vw - 132px - 16px, 1162px);
  }
}
@media (hover: hover) and (pointer: fine) {
  .slider__arrow:hover {
    cursor: pointer;
    background-color: var(--Static-White);
    stroke: var(--Primary);
  }
}
.timer {
  display: flex;
  flex-direction: column;
  gap: 8px;
}
.timer__time {
  padding: 8px 12px;
  display: flex;
  background-color: var(--Static-White-40);
  border-radius: 20px;
}
.timer__section {
  position: relative;
  display: flex;
  flex-direction: column;
  width: 80px;
}
.timer__section:not(:first-child)::after {
  position: absolute;
  top: 15px;
  content: "";
  width: 1px;
  height: 20px;
  background-color: var(--Static-White);
}
.timer__number {
  text-align: center;
  font-size: 24px;
  line-height: 152%; /* 36.48px */
  letter-spacing: 3.84px;
  text-transform: uppercase;
}
.timer__text {
  text-align: center;
  font-size: 12px;
  line-height: 130%; /* 15.6px */
  letter-spacing: 0.6px;
  text-transform: uppercase;
}

.burger-menu {
  display: none;
  cursor: pointer;
  width: 40px;
  height: 40px;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  box-sizing: border-box;
  border-radius: 100px;
  position: relative;
  top: -4px;
}
.burger-menu_active .burger-menu__item:first-child {
  transform: rotate(45deg);
}
.burger-menu_active .burger-menu__item:last-child {
  transform: rotate(-45deg);
}
.burger-menu__item {
  position: absolute;
  width: 20px;
  height: 1px;
  background-color: var(--Dark);
  transition: transform 0.3s ease-in;
}
.burger-menu__item:first-child {
  transform: translateY(4px);
}
.burger-menu__item:last-child {
  transform: translateY(-4px);
}

@media only screen and (max-width: 768px) {
  .burger-menu {
    display: flex;
  }
}
html {
  scroll-behavior: smooth;
}

/*# sourceMappingURL=style.cs.map */
