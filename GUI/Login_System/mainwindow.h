#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QtSql/QSql>
#include <QSqlDatabase>
#include<QMessageBox>
#include <adminwindow.h>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_loginButton_clicked();

private:
    Ui::MainWindow *ui;

    adminwindow *adminDash;     //instance of adminwindow for creation of dashboard
    QSqlDatabase Login_Database; //Sql database object
};

#endif // MAINWINDOW_H
