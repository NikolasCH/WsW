﻿using UnityEngine;
using System.Collections;

public class baza : MonoBehaviour {
	
	public static  string[,]	words = new string[,]{
		{"","",""},	

		{"мусорщик","12","щур,кум,сук,рок,иск,сок,мир,ром,урок,морс,кумир,мусор"},
		{"полисмен","12","лес,нос,сом,лом,пол,сон,мел,лис,слон,поле,лимон,олимп"},
		{"табунщик","12","бит,тик,кат,акт,кит,щит,бак,куб,щука,танк,табун,нитка"},
		{"златоуст","12","сто,туз,зал,лот,уза,оса,зло,таз,стол,сало,засол,злато"},
		{"забрало","12","раз,зал,лор,бал,зло,раб,бар,лоб,роза,база,базар,забор"},
		{"укротить","12","тур,ток,рот,кот,кит,кут,рок,тир,крот,торт,ртуть,турок"},
		{"дробовик","12","рок,вор,око,код,вид,бок,род,ров,обод,двор,добро,короб"},
		{"жидкость","12","кот,ось,кит,сто,иск,ток,сок,код,диск,сито,кость,кисть"},
		{"пассажир","12","жир,пас,рис,сир,пар,ржа,жар,пир,пара,жара,париж,расса"},
		{"жадность","12","оса,нос,нож,сад,сон,тон,дно,ось,нота,сода,станд,стадо"},
		{"закопать","12","кат,опт,ток,кот,пот,акт,паз,таз,поза,коза,капот,закат"},
		{"мавзолей","12","зам,зов,вал,май,лев,мел,зло,лом,змей,овал,мойва,взлом"},
		{"молекула","12","мел,ком,лом,кум,кол,лук,лак,мак,мука,укол,кумол,омела"},
		{"блокада","12","бал,бак,код,лак,лоб,кол,бок,док,клад,блок,лодка,бокал"},
		{"живность","12","тон,ось,инь,сто,нос,сон,нож,сот,вино,винт,живот,жниво"},
		{"крокодил","12","лор,код,кол,рол,рок,род,око,док,лорд,крик,ролик,окрик"},
		{"аэроплан","12","эра,лор,пар,рэп,рол,пан,пол,нло,план,лапа,напор,рапан"},
		{"декольте","12","лот,ель,код,кол,ток,кот,док,лед,лето,отел,колье,отель"},
		{"живность","12","тон,ось,инь,сто,нос,сон,нож,сот,вино,винт,живот,жниво"},
		{"единорог","12","гон,год,гид,род,рог,дно,орг,ген,ринг,горе,город,орден"},
		{"двоечник","12","чин,дно,век,чек,вид,код,док,дон,очки,кино,венок,видео"},
		{"сетчатка","12","акт,сет,чек,чат,час,кат,сак,чет,тест,такт,сетка,текст"},
		{"даритель","12","ера,лад,ель,тир,еда,дар,три,арт,леди,литр,дрель,лидер"},
		{"заклеить","12","тик,лак,кит,таз,зал,ель,кат,акт,теза,злак,тазик,литье"},
		{"телефакс","12","сет,акт,фас,лес,кат,лак,сак,лат,факс,кафе,леска,факел"},
		{"чиновник","12","вин,вич,ник,чин,квн,кон,воин,кино,очки,очник,новик,никон"},
		{"виселица","12","ева,лев,лес,вес,вал,лис,слив,лиса,сила,слива,весла,валец"},
		{"вестник","12","сет,век,кит,иск,ник,вес,свет,винт,твин,веник,вести,кисет"},
		{"механизм","12","зам,маз,хам,хан,мех,низ,мина,зима,заем,аниме,хиазм,имена"},
		{"мочалка","12","ком,лом,кол,лак,мак,чал,кома,мачо,кола,мочка,калач,чолка"},
		{"вельможа","12","ева,жом,вал,ель,лом,мел,ложа,овал,жало,молва,омела,авель"},
		{"перекись","12","пир,пик,сир,иск,рис,икс,риск,пирс,серп,ересь,скрип,крепь"},
		{"суконщик","12","нос,сук,сон,сок,кон,кук,усик,кино,укос,киоск,конус,кусок"},
		{"камуфляж","12","кум,жук,лак,лук,муж,яма,маяк,мука,лужа,лямка,муляж,кафля"},
		{"навсегда","12","ева,вес,гад,сад,еда,сан,снег,вена,гнев,навес,весна,аванс"},
		{"дракон","12","дно,рок,род,рак,дар,код,кора,кран,нора,крона,народ,норка"},
		{"батальон","12","тон,лот,лоб,бал,бот,бан,болт,бант,нота,табло,батон,талон"},
		{"имитатор","12","том,рот,тир,мат,мир,ром,омар,ритм,торт,томат,мирта,ортит"},
		{"юродство","12","вор,рот,род,сто,ров,сор,рост,сорт,трос,отвод,ворот,створ"},
		{"лабиринт","12","бит,бал,тир,бар,раб,бин,бант,блин,бинт,тиран,алиби,барин"},
		{"редакция","12","ера,еда,рак,дар,ряд,акр,икра,цирк,река,дикая,акция,рация"},
		{"агитатор","12","рог,гит,тир,гот,рот,арт,игра,гора,тигр,аорта,отара,трата"},
		{"дурнушка","12","рак,шар,куш,дар,душ,днк,уран,шнур,кран,раунд,шкура,дурак"},
		{"оператор","12","ера,опт,пар,пот,рот,арт,трап,перо,порт,тропа,опера,топор"},
		{"оговорка","12","рок,рак,рог,ров,вор,око,гора,кора,враг,кагор,горка,овраг"},
		{"ржавчина","12","чин,жир,жар,чан,ржа,чиж,врач,рана,жара,жнива,вираж,навар"},
		{"нумизмат","12","зам,унт,маз,таз,туз,мат,муза,зима,мина,мазут,манту,туман"},
		{"кабанчик","12","бак,чин,чан,бан,ник,каб,банк,кана,чина,банка,кабак,чабан"},
		{"наличник","12","чан,чин,лак,нал,ник,нил,клан,ланч,клин,начин,клинч,чинка"},
		{"табачник","12","бит,кит,акт,чин,чан,кат,танк,банк,бант,нитка,канат,банка"},
		{"камнепад","12","еда,мак,пан,кад,мед,дама,панк,пена,адам,декан,панда,дамка"},
		{"динамика","12","дан,мак,кад,ник,ким,адам,дама,мина,дина,дамка,камин,манка"},
		{"рептилия","12","пир,тир,тип,реп,лет,литр,тире,теля,трип,петля,пирит,питер"},
		{"рытвина","12","ива,тир,вин,тан,тын,вина,нрав,винт,твин,тиран,нарыв,инвар"},
		{"желтизна","12","таз,зал,низ,лет,зат,тени,лиза,зина,жиле,линза,лента,зенит"},
		{"задачник","12","чад,чин,чан,зад,ник,знак,дача,кана,канд,казан,казна,кинза"},
		{"балдахин","12","хна,хан,бал,дан,хаб,блин,лада,банд,бада,банда,нахал,балда"},
		{"классика","12","лак,лис,иск,сак,кал,лиса,сила,скал,клик,клака,каска,скала"},
		{"амазонка","12","зам,маз,мак,кон,зак,коза,знак,зона,кома,манка,казна,закон"},
		{"марципан","12","мир,пар,пир,пан,пин,рама,рана,мина,пиар,панир,пацан,принц"},
		{"мандарин","12","мир,дар,дан,рад,дир,рана,дама,мина,рада,драма,динар,манна"},
		{"неувязка","12","вуз,ева,век,зак,кан,внук,знак,указ,звук,кавун,кузня,вязка"},
		{"таракан","12","кат,акт,рак,кан,нар,кран,танк,арка,карта,канат,карат,таран"},
		{"вариант","12","ива,тир,ват,нат,тар,тара,вина,винт,тиран,врата,таран,трава"},
		{"ерничать","12","тир,чин,чат,чан,чит,тени,речь,нить,тень,черта,тиран,тачин"},
		{"ларингит","12","гит,тир,лат,нил,лаг,литр,игла,ринг,игра,грант,тиран,глина"},
		{"марганец","12","маг,гар,ган,рам,ран,герц,рама,рана,цена,арена,ангар,гарем"},
		{"звонница","12","ваз,зов,ива,воз,вин,звон,виза,вино,вина,зона,навоз,вазон"},
		{"резинка","12","ера,рак,зак,зик,рез,икра,река,знак,кран,кирза,резак,кинза"},
		{"рукавица","12","рак,ива,цик,рав,цар,цирк,кара,икра,аура,варка,кварц,рукав"},
		{"вакансия","12","иск,кан,сан,вис,сия,квас,явка,свая,вина,синяк,аванс,санки"},
		{"хрусталь","12","тур,уха,тас,лат,сут,слух,суть,руль,стул,сталь,страх,хруст"},
		{"завтрак","12","кат,акт,рак,таз,ват,вата,тара,ваза,катар,закат,карат,азарт"},
		{"ирландец","12","ера,лад,еда,дар,лир,цена,леди,циан,дина,лидер,недра,дилер"},
		{"дизайнер","12","дар,еда,рай,зад,низ,езда,нард,зина,иран,нарез,динар,радий"},
		{"лезгинка","12","зал,газ,лак,зак,ник,злак,глаз,знак,клан,линза,кинза,книга"},
		{"марсиане","12","ера,рис,мир,сир,нар,рана,мера,марс,рама,арена,смена,саран"},
		{"финалист","12","тиф,фан,фас,лис,нал,фиат,лист,аист,сила,сатин,флинт,финал"},
		{"каскадер","12","сад,рак,дар,еда,кекс,река,арка,кедр,среда,краса,драка,адрес"},
		{"снегопад","12","нос,еда,сон,сад,пена,нога,снег,сода,десна,пегас,сапог,седан"},
		{"обляпать","12","пол,пот,бал,опт,болт,боль,плот,опал,табло,плоть,толпа,плато"},
		{"вагончик","12","гон,чан,ива,чин,вино,кино,воин,нога,икона,гонка,вагон,книга"},
		{"сбривать","12","бар,бит,рис,тир,аист,брат,сват,бита,абрис,битва,свита,тварь"},
		{"луковица","12","ива,кол,лак,лук,волк,лицо,укол,цикл,вилка,вокал,улика,улица"},
		{"салфетка","12","кат,лак,лес,акт,факс,скат,кафе,факт,скала,факел,салат,атлас"},
		{"гарнитур","12","арт,гит,тир,тур,ринг,уран,тигр,игра,тиран,руина,грунт,грант"},
		{"чайнворд","12","дар,рой,йод,чай,нора,нрав,двор,вода,народ,ранчо,дрова,война"},
		{"молчанка","12","лом,мак,ком,лак,клон,клан,мачо,ланч,мочка,манка,калач,канал"},
		{"табачник","12","бит,кит,акт,кат,танк,банк,бант,ткач,табак,нитка,канат,банка"},
		{"закурить","12","туз,акт,рак,кит,тура,икра,рука,утка,кирза,турка,тазик,круиз"},
		{"морковка","12","ром,мак,рак,вор,кора,корм,омар,мрак,корка,корма,ковка,комар"},
		{"ночлежка","12","чан,чек,нож,лак,кожа,клан,клон,ланч,ножка,океан,ложка,лежак"},
		{"ехидство","12","сет,вид,ход,вес,овес,свет,сито,вето,видео,хвост,отвес,совет"},
		{"импортер","12","пир,пот,мир,тир,море,перо,порт,метр,прием,проем,помет,метро"},
		{"акварель","12","лак,век,ель,лев,лавр,река,арка,вера,лавка,аврал,варка,клава"},
		{"талисман","12","лат,нил,мат,лис,мина,лиса,сила,аист,салат,лиман,сатин,астма"},
		{"тетрадка","12","акт,рак,еда,дар,кадр,арка,дата,река,карат,театр,карта,актер"},
		{"времянка","12","мак,век,рак,яма,маяк,кран,река,крем,время,анкер,мерка,намек"},
		{"медалист","12","сад,мел,еда,мат,сила,лист,аист,леди,диета,метис,смета,идеал"},
		{"богатырь","12","бот,бар,рог,рот,рыба,гора,рота,брат,батог,аборт,табор,торба"},
		{"обрезать","12","бар,таз,раб,бот,роза,азот,роба,рота,образ,забор,зебра,обрез"},
		{"разборка","12","бар,бак,рак,бок,база,краб,коза,арка,базар,барак,кобра,забор"},
		{"карусель","12","сук,лес,лук,рак,река,рука,руль,курс,скула,ларек,леска,рельс"},
		{"насушить","12","шут,туш,инь,аист,суть,нить,шина,уста,ниша,шанс,сатин,шатун"},
		{"паутинка","12","акт,кит,пик,кант,кнут,паук,танк,утка,канат,наука,нитка,пункт"},
		{"пистолет","12","лес,пол,тип,лето,лист,пост,стол,тест,отлет,пилот,полис,столп"},
		{"мерзость","12","ось,ром,рот,метр,море,мост,рост,сеть,место,месть,метро,смотр"},
		{"марксизм","12","иск,мир,рис,зима,икра,марс,риск,сказ,искра,миска,симка,кирза"},
		{"оккупант","12","акт,кот,тон,кант,кнут,нота,пакт,утка,каток,купон,откуп,пункт"},
		{"снегурка","12","рак,сук,грек,крен,круг,курс,ранг,рагу,анкер,гусар,нерка,скена"},
		{"свинопас","12","ива,нос,оса,вино,воин,оспа,пиво,пони,насос,осина,сосна,спина"},
		{"панибрат","12","бар,пар,тип,бант,бинт,пари,рана,трап,барин,парта,пират,таран"},
		{"директор","12","кит,код,рот,ирод,кедр,корт,крот,отек,декор,кредо,ордер,ротик"},
		{"заложник","12","лак,нож,лож,жила,злак,знак,клан,клон,закон,икона,кинза,линза"},
		{"патронаж","12","жор,пар,пот,жанр,порт,рожа,рота,жопа,отара,парта,таран,тропа"},
		{"заложник","12","кол,лак,нож,злак,клан,клин,клон,коза,жилка,закон,линза,ложка"},
		{"прислуга","12","лис,луг,суп,гипс,игла,лига,лиса,пари,гусар,испуг,парус,слуга"},
		{"апельсин","12","лес,пас,инь,лань,пена,пень,сила,сани,пенал,пьеса,слань,спина"},
		{"лепесток","12","кол,кот,лес,отек,плот,полк,пост,скот,пекло,песок,плеск,склеп"},
		{"рисовать","12","вор,оса,тир,рать,сова,сорт,торс,трио,отвар,рвота,свита,ситро"},
		{"телескоп","12","лот,опт,пот,клоп,плот,скот,сток,толк,пекло,песок,полет,тепло"},
		{"патиссон","12","нос,пас,пот,нота,оспа,пони,сноп,понт,насос,пинта,питон,сосна"},
		{"болванка","12","бал,вал,лоб,банк,клон,кола,лава,овал,бланк,вобла,кабан,колба"},
		{"моралист","12","лом,мат,сом,лира,литр,морс,рост,сила,ислам,масло,ситро,смола"},
		{"брусника","12","иск,куб,сир,брус,краб,курс,сруб,уран,рубин,рубка,руина,скрин"},
		{"перловка","12","век,лак,рок,вера,пора,лавр,плов,евро,парок,левак,опера,право"},
		{"канистра","12","тик,рис,иск,кант,скат,риск,скрин,канат,транс,накат,такса,сатин"},
		{"вокалист","12","вал,акт,сто,сито,сота,авто,коса,квас,висок,квота,свита,виток"},
		{"обмолвка","12","лак,лоб,мак,блок,волк,кома,овал,бокал,вобла,колба,молва,облом"},
		{"макароны","12","рак,рык,кор,корм,кран,мрак,омар,комар,коран,марка,норма,рамка"},
		{"зрелость","12","зло,лес,ось,зеро,лось,орел,роль,лесть,осетр,отель,отрез,рельс"},
		{"карантин","12","кит,тик,тир,кант,кран,рана,танк,канат,карат,накат,нитка,тиран"},
		{"метафора","12","мат,том,ром,арфа,атом,метр,фарт,аорта,афера,метро,ферма,форма"},
		{"тенниска","12","кат,сет,тик,аист,кант,скат,сани,киста,нитка,сатин,секта,такси"},
		{"фонетика","12","кот,тиф,фон,кафе,кино,кофе,факт,икона,икота,океан,тоник,фотка"},
		{"недоимка","12","дно,еда,дан,мина,мода,наем,один,декан,домен,донка,камин,медиа"},
		{"быстрота","12","бас,быт,раб,борт,рост,рыба,сбор,аборт,старт,табор,торба,траст"},
		{"дворняга","12","гад,дар,ярд,враг,град,нога,ядро,аргон,вагон,гранд,народ,ягода"},
		{"разминка","12","мак,мир,рак,арка,зима,кара,мина,заика,казан,манка,марка,наказ"},
		{"волокита","12","акт,ива,лот,авто,волк,окот,толк,актив,виток,квота,отвал,отлив"},
		{"глазомер","12","гол,зал,зло,гром,зеро,лоза,мгла,гроза,залог,замер,лазер,могар"},
		{"братишка","12","бак,тир,шар,ишак,краб,штаб,бита,барак,карат,рикша,табак,шарик"},
		{"искупать","12","пас,сук,суп,аист,куст,паук,пуск,кисть,пасть,скаут,такси,тупик"},
		{"виноград","12","дар,дно,род,диво,игра,ирод,нива,гнида,грива,народ,овраг,радио"},
		{"фабрикат","12","риф,фри,три,арфа,краб,факт,фарт,барак,карта,табак,тариф,фибра"},
		{"дубликат","12","куб,кут,лук,блат,блик,клад,клуб,будка,булка,улика,бутик,аудит"},
		{"автограф","12","рот,рог,гот,арфа,вата,граф,торф,автор,аорта,графа,рвота,тавро"},
		{"ватрушка","12","куш,рак,шар,аура,рута,тура,утка,ракша,рукав,трава,шавка,шкура"},
		{"нотариус","12","нос,сир,тур,руно,сито,уран,уста,нутро,руина,сатин,ситро,тонус"},
		{"пролётка","12","кат,кол,лак,ёлка,парк,плот,полк,капот,плато,полка,порка,толпа"},
		{"микстура","12","кум,мир,сук,амур,кума,марс,ритм,камус,кумир,симка,смута,сутки"},
		{"подливка","12","код,лад,кпд,вода,клип,липа,пиво,вклад,водка,олива,пилка,падло"},
		{"проделка","12","дар,еда,рол,дело,депо,кадр,перо,кредо,опера,парок,пекло,покер"},
		{"агентура","12","ера,тур,аура,рагу,ранг,рута,уран,агент,ангар,грунт,нагар,таран"},
		{"карамель","12","ель,лак,арка,кара,крем,мера,река,ларек,марка,мерка,рамка,карма"},
		{"неправда","12","дар,пан,нрав,дева,нерв,рана,пена,арена,недра,парад,панда,навар"},
		{"горбунок","12","бок,куб,горб,круг,руно,урок,урон,бугор,гонор,короб,обгон,округ"},
		{"клоунада","12","дно,дан,клад,клон,луна,укол,улан,акула,канал,клоун,лодка,наука"},
		{"картинка","12","кит,тик,икра,кант,кара,кран,крик,аркан,канат,карат,карта,тиран"},
		{"скатерть","12","сет,рак,сеть,скат,такт,тест,трек,актер,арест,катер,крест,секта"},
		{"голкипер","12","пик,рог,горе,клип,орел,перо,полк,игрек,игрок,ликер,пекло,пирог"},
		{"ласточка","12","сок,час,коса,сало,скат,скол,ткач,салат,сачок,скотч,такса,тоска"},
		{"мольберт","12","бот,рол,боль,бром,лето,мель,моль,метро,омлет,отель,тембр,тромб"},
		{"нарколог","12","око,рак,клан,лоно,окно,ранг,аргон,гонка,гонор,коран,ларго,локон"},
		{"верность","12","ров,сон,вето,вонь,ворс,нерв,овес,осень,осетр,отсев,совет,тонер"},
		{"лавочник","12","кол,лак,клан,клин,нива,очки,ланч,валик,вилка,вокал,волан,волна"},
		{"кислород","12","лис,сок,диск,идол,лорд,риск,сидр,колос,ролик,сидор,оксид,диско"},
		{"единство","12","вес,дно,винт,воин,овен,один,сено,видео,невод,отвес,отсев,совет"},
		{"вурдалак","12","лук,рак,аура,дура,кадр,лава,рада,аврал,акула,драка,дурак,курва"},
		{"народник","12","дан,дно,ирод,кадр,кран,один,орда,анион,динар,донка,крона,народ"},
		{"гармошка","12","гам,ком,грош,корм,морг,омар,шрам,кагор,марка,ракша,рамка,карма"},
		{"одалиска","12","сад,сок,диск,идол,сила,скол,сода,доска,лодка,ослик,садик,склад"},
		{"летопись","12","пол,сто,лось,плот,поле,пост,село,отель,пилот,питье,плеть,плоть"},
		{"перчатка","12","чек,чат,карп,пакт,парк,репа,трап,катер,пачка,печка,речка,чакра"},
		{"апостроф","12","пот,фас,оспа,порт,рапс,сорт,фарс,опора,пафос,просо,стопа,топор"},
		{"селектор","12","рол,сок,корт,крот,орел,реле,сорт,осетр,отсек,серое,тесло,треск"},
		{"мелкость","12","ель,ком,моль,мост,отек,село,скол,колье,кольт,лесть,месть,омлет"},
		{"карбонад","12","раб,дан,бард,брак,брод,краб,орда,банда,барон,донка,драка,кобра"},
		{"памятник","12","маяк,мина,мята,пакт,пика,тмин,камин,мания,нитка,пинта,пятак,пятка"},
		{"колкость","12","кокс,лось,скол,скот,соль,сток,кокос,колос,кольт,коток,лоток,откол"},
		{"невестка","12","вена,кант,квас,сват,свет,скат,весна,ветка,навес,секта,сенат,стена"},
		{"самоучка","12","коса,смак,чума,сумо,мачо,умка,камус,маска,самка,сачок,сумка,сучок"},
		{"частушка","12","каша,куст,туча,туша,усач,утка,каста,скаут,такса,чашка,штука,шутка"},
		{"горемыка","12","гром,кома,корм,крем,мера,море,гарем,кагор,комар,корма,мерка,омега"},
		{"локотник","12","клик,клон,лото,окно,окот,толк,кокон,коток,локон,лоток,никто,нолик"},
		{"ресторан","12","енот,нора,рост,сено,сера,стон,арест,осетр,сенат,сонет,стена,тенор"},
		{"теплушка","12","купе,лупа,пакт,паук,туша,утка,пакет,пешка,пушка,тушка,штука,шутка"},
		{"лампочка","12","клоп,лапа,плач,полк,мачо,пока,калач,копач,лампа,ломка,палка,пачка"},
		{"глупость","12","гусь,плуг,пост,путь,соль,стог,гость,плоть,пульс,пульт,столп,уголь"},
		{"государь","12","гарь,гусь,друг,орда,роса,удар,грудь,гусар,досуг,согра,угода,угорь"},
		{"считалка","12","ткач,киса,калач,каста,киста,латка,салат,силач,такса,такси,атлас,чикса"},
		{"жердочка","12","кадр,кедр,орда,чадо,декор,дочка,драже,кредо,очерк,речка,чреда,кодер"},
		{"догматик","12","атом,итог,кома,маки,мода,годик,догма,икота,магик,томик,гомик,домик"},
		{"хиромант","12","мина,охра,ритм,тмин,хорт,хром,монах,норма,рахит,роман,тиран,хитон"},
		{"истерика","12","ирис,риск,сера,скат,тире,трек,актер,арест,искра,катер,секта,сетка"},
		{"ревность","12","вонь,ворс,ость,рост,свет,сорт,весть,ворье,осень,совет,сонет,тенор"},
		{"таинство","12","винт,воин,нива,сито,тост,отит,навис,осина,сатин,свита,твист,титан"},
		{"редкость","12","корт,корь,отек,сеть,срок,трос,декор,досье,кредо,осетр,треск,кодер"},
		{"организм","12","зима,игра,мина,мозг,ринг,роза,загон,измор,норма,роман,орган,мозги"},
		{"congratulations","12","girl,lion,coin,aunt,goat,until,onion,train,action,nation,notion,location"}
		//{"украсить","12","курс,куст,рать,стук,суть,трус,искра,киста,кисть,скаут,такси,сутки"},
		//{"зубоскал","12","злак,клуб,лоза,сказ,указ,бакс,блуза,закол,засол,злоба,казус,обуза"},
		//{"графство","12","роса,рота,сват,софа,стог,торг,овраг,отвар,рвота,свора,тавро,товар"},
		//{"исколоть,,8,,лист,лось,сито,стол,толк,слот,исток,кольт,лоток,лотос,окись,стиль"}

	};
	
}
