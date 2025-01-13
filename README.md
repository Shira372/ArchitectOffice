משרד אדריכליות:

תיאור הפרויקט:

מערכת לניהול פגישות של לקוחות עם האדריכלית שעתידה לתכנן את ביתם. באמצעות המערכת ניתן להזמין פגישה לאדריכלית ולנהל את כלל הפגישות במשרד.

ישויות:

לקוח

אדריכלית

פגישה

מיפוי Routes ללקוח:

שליפת רשימת הלקוחות GET https://office.co.il/customers שליפת לקוח לפי מזהה GET https:// office.co.il/ customers /1 הוספת לקוח POST https:// office.co.il/ customers עדכון לקוח PUT https:// office.co.il/ customers /1

מיפוי Routes לאדריכליות:

שליפת רשימת האדריכליות GET https:// office.co.il/architects שליפת אדריכלית לפי מזהה GET https:// office.co.il/ architects /1 הוספת אדריכלית POST https:// office.co.il/ architects עדכון אדריכלית PUT https:// office.co.il/ architects /1

מיפוי Routes לפגישות:

שליפת רשימת הפגישות GET https:// office.co.il/meetings שליפת פגישה לפי מזהה GET https:// office.co.il/ meetings /1 הוספת פגישה POST https:// office.co.il/ meetings עדכון פגישה PUT https:// office.co.il/ meetings /1 מחיקת פגישה DELETE https:// office.co.il/ meetings /1 בחרתי לא למפות Routes למחיקת לקוח ואדריכלית. במקום זה אוסיף Routes לעדכון סטטוס PUT https:// office.co.il/ customers /1/status PUT https:// office.co.il/ architects /1/status
