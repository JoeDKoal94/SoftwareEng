/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.12.3
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtGui/QIcon>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGroupBox>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralWidget;
    QWidget *topPanel;
    QWidget *headerIcon;
    QLabel *headerName;
    QGroupBox *loginForm;
    QPushButton *loginButton;
    QWidget *widget;
    QVBoxLayout *verticalLayout;
    QLineEdit *userName;
    QLineEdit *userPassword;
    QWidget *widget1;
    QVBoxLayout *verticalLayout_2;
    QWidget *clientIcon;
    QWidget *lockIcon;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QString::fromUtf8("MainWindow"));
        MainWindow->resize(1200, 900);
        MainWindow->setMinimumSize(QSize(1200, 900));
        QIcon icon;
        icon.addFile(QString::fromUtf8(":/images/Login.jpg"), QSize(), QIcon::Normal, QIcon::Off);
        MainWindow->setWindowIcon(icon);
        MainWindow->setAutoFillBackground(true);
        MainWindow->setStyleSheet(QString::fromUtf8("#centralWidget{\n"
"\n"
"	background-image: url(:/images/bg.png);\n"
"\n"
"}"));
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        topPanel = new QWidget(centralWidget);
        topPanel->setObjectName(QString::fromUtf8("topPanel"));
        topPanel->setGeometry(QRect(10, 0, 1191, 80));
        topPanel->setMinimumSize(QSize(800, 2));
        topPanel->setStyleSheet(QString::fromUtf8("#topPanel{\n"
"\n"
"	background-color: qlineargradient(spread:pad, x1:0, y1:0, x2:1, y2:0, stop:0 rgba(0, 0, 0, 255), stop:1 rgba(255, 255, 255, 255));\n"
"\n"
"}"));
        headerIcon = new QWidget(topPanel);
        headerIcon->setObjectName(QString::fromUtf8("headerIcon"));
        headerIcon->setGeometry(QRect(1040, 0, 111, 81));
        headerIcon->setStyleSheet(QString::fromUtf8("#headerIcon{\n"
"\n"
"	border-image: url(:/images/main-icon.png);\n"
"\n"
"}"));
        headerName = new QLabel(topPanel);
        headerName->setObjectName(QString::fromUtf8("headerName"));
        headerName->setGeometry(QRect(710, 10, 361, 57));
        QFont font;
        font.setFamily(QString::fromUtf8("MV Boli"));
        font.setPointSize(26);
        headerName->setFont(font);
        loginForm = new QGroupBox(centralWidget);
        loginForm->setObjectName(QString::fromUtf8("loginForm"));
        loginForm->setGeometry(QRect(330, 220, 481, 381));
        QFont font1;
        font1.setPointSize(10);
        font1.setBold(true);
        font1.setWeight(75);
        loginForm->setFont(font1);
        loginForm->setLayoutDirection(Qt::LeftToRight);
        loginForm->setAutoFillBackground(true);
        loginForm->setStyleSheet(QString::fromUtf8(""));
        loginForm->setAlignment(Qt::AlignCenter);
        loginButton = new QPushButton(loginForm);
        loginButton->setObjectName(QString::fromUtf8("loginButton"));
        loginButton->setGeometry(QRect(310, 250, 111, 31));
        QFont font2;
        font2.setPointSize(9);
        font2.setBold(true);
        font2.setWeight(75);
        loginButton->setFont(font2);
        loginButton->setStyleSheet(QString::fromUtf8("#loginButton{\n"
"\n"
"	background-color: rgb(85, 170, 255);\n"
"\n"
"}\n"
"\n"
"#loginButton:hover{\n"
"\n"
"\n"
"	background-color: rgb(255, 255, 0);\n"
"\n"
"}"));
        widget = new QWidget(loginForm);
        widget->setObjectName(QString::fromUtf8("widget"));
        widget->setGeometry(QRect(160, 80, 261, 141));
        verticalLayout = new QVBoxLayout(widget);
        verticalLayout->setSpacing(6);
        verticalLayout->setContentsMargins(11, 11, 11, 11);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        verticalLayout->setContentsMargins(0, 0, 0, 0);
        userName = new QLineEdit(widget);
        userName->setObjectName(QString::fromUtf8("userName"));
        QFont font3;
        font3.setPointSize(12);
        userName->setFont(font3);

        verticalLayout->addWidget(userName);

        userPassword = new QLineEdit(widget);
        userPassword->setObjectName(QString::fromUtf8("userPassword"));
        userPassword->setFont(font3);
        userPassword->setEchoMode(QLineEdit::Password);

        verticalLayout->addWidget(userPassword);

        widget1 = new QWidget(loginForm);
        widget1->setObjectName(QString::fromUtf8("widget1"));
        widget1->setGeometry(QRect(20, 90, 171, 111));
        verticalLayout_2 = new QVBoxLayout(widget1);
        verticalLayout_2->setSpacing(6);
        verticalLayout_2->setContentsMargins(11, 11, 11, 11);
        verticalLayout_2->setObjectName(QString::fromUtf8("verticalLayout_2"));
        verticalLayout_2->setContentsMargins(0, 0, 0, 0);
        clientIcon = new QWidget(widget1);
        clientIcon->setObjectName(QString::fromUtf8("clientIcon"));
        clientIcon->setStyleSheet(QString::fromUtf8("#clientIcon{\n"
"\n"
"	image: url(:/images/client-icon.png);\n"
"\n"
"}"));

        verticalLayout_2->addWidget(clientIcon);

        lockIcon = new QWidget(widget1);
        lockIcon->setObjectName(QString::fromUtf8("lockIcon"));
        lockIcon->setStyleSheet(QString::fromUtf8("#lockIcon{\n"
"\n"
"	image: url(:/images/lock-icon.jpeg);\n"
"\n"
"}"));

        verticalLayout_2->addWidget(lockIcon);

        MainWindow->setCentralWidget(centralWidget);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "Login", nullptr));
        headerName->setText(QApplication::translate("MainWindow", "Ed. Board", nullptr));
        loginForm->setTitle(QApplication::translate("MainWindow", "LOGIN", nullptr));
        loginButton->setText(QApplication::translate("MainWindow", "Enter", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
