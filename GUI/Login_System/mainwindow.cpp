#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QMessageBox>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    ui->userName->setPlaceholderText("Enter username");
    ui->userPassword->setPlaceholderText("Enter password");

}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_loginButton_clicked()
{
    QString tempUsername = ui->userName->text();
    QString tempPassword = ui->userPassword->text();

    if (tempUsername == "admin" && tempPassword == "test")
    {
        QMessageBox::information(this, "Login", "Username and password is correct.");
        adminDash = new adminwindow(this);
        adminDash->show();

    }
    else{
        QMessageBox::warning(this, "Login", "Username and password is not correct.");
    }

}
