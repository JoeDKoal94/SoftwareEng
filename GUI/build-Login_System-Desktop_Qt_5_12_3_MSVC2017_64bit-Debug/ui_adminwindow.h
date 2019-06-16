/********************************************************************************
** Form generated from reading UI file 'adminwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.12.3
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_ADMINWINDOW_H
#define UI_ADMINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialog>
#include <QtWidgets/QFrame>
#include <QtWidgets/QLabel>

QT_BEGIN_NAMESPACE

class Ui_adminwindow
{
public:
    QFrame *line;
    QLabel *dashLabel;

    void setupUi(QDialog *adminwindow)
    {
        if (adminwindow->objectName().isEmpty())
            adminwindow->setObjectName(QString::fromUtf8("adminwindow"));
        adminwindow->resize(1920, 1200);
        adminwindow->setMinimumSize(QSize(1920, 1200));
        adminwindow->setStyleSheet(QString::fromUtf8("#adminwindow{\n"
"\n"
"	background-color: qlineargradient(spread:pad, x1:0, y1:0, x2:1, y2:0, stop:0 rgba(128, 192, 255, 255), stop:1 rgba(255, 255, 255, 255));\n"
"\n"
"}"));
        line = new QFrame(adminwindow);
        line->setObjectName(QString::fromUtf8("line"));
        line->setGeometry(QRect(0, 80, 1341, 16));
        line->setFrameShape(QFrame::HLine);
        line->setFrameShadow(QFrame::Sunken);
        dashLabel = new QLabel(adminwindow);
        dashLabel->setObjectName(QString::fromUtf8("dashLabel"));
        dashLabel->setGeometry(QRect(80, 10, 311, 61));
        QFont font;
        font.setFamily(QString::fromUtf8("MV Boli"));
        font.setPointSize(22);
        font.setBold(false);
        font.setWeight(50);
        dashLabel->setFont(font);
        dashLabel->setStyleSheet(QString::fromUtf8("#dashLabel{\n"
"\n"
"	\n"
"	color: rgb(255, 255, 255);\n"
"\n"
"}"));

        retranslateUi(adminwindow);

        QMetaObject::connectSlotsByName(adminwindow);
    } // setupUi

    void retranslateUi(QDialog *adminwindow)
    {
        adminwindow->setWindowTitle(QApplication::translate("adminwindow", "Administrator ", nullptr));
        dashLabel->setText(QApplication::translate("adminwindow", "Dashboard", nullptr));
    } // retranslateUi

};

namespace Ui {
    class adminwindow: public Ui_adminwindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_ADMINWINDOW_H
