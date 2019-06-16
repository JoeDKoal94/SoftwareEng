/********************************************************************************
** Form generated from reading UI file 'dashboard.ui'
**
** Created by: Qt User Interface Compiler version 5.12.3
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_DASHBOARD_H
#define UI_DASHBOARD_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QDialog>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_dashLabel
{
public:
    QWidget *dashHeader;

    void setupUi(QDialog *dashLabel)
    {
        if (dashLabel->objectName().isEmpty())
            dashLabel->setObjectName(QString::fromUtf8("dashLabel"));
        dashLabel->resize(1920, 1200);
        dashLabel->setMinimumSize(QSize(1920, 1200));
        dashLabel->setStyleSheet(QString::fromUtf8("#dashboard{\n"
"background-color: qlineargradient(spread:pad, x1:0, y1:0, x2:1, y2:0, stop:0 rgba(128, 192, 255, 255), stop:1 rgba(255, 255, 255, 255));\n"
"}"));
        dashHeader = new QWidget(dashLabel);
        dashHeader->setObjectName(QString::fromUtf8("dashHeader"));
        dashHeader->setGeometry(QRect(0, 0, 1921, 101));
        dashHeader->setStyleSheet(QString::fromUtf8("#dashHeader{\n"
"\n"
"	\n"
"	border-image: url(:/images/header.jpg);\n"
"\n"
"}"));

        retranslateUi(dashLabel);

        QMetaObject::connectSlotsByName(dashLabel);
    } // setupUi

    void retranslateUi(QDialog *dashLabel)
    {
        dashLabel->setWindowTitle(QApplication::translate("dashLabel", "Dialog", nullptr));
    } // retranslateUi

};

namespace Ui {
    class dashLabel: public Ui_dashLabel {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_DASHBOARD_H
