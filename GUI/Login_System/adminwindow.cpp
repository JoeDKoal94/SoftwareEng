#include "adminwindow.h"
#include "ui_adminwindow.h"

adminwindow::adminwindow(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::adminwindow)
{
    ui->setupUi(this);
}

adminwindow::~adminwindow()
{
    delete ui;
}
