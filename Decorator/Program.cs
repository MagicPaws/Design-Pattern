using Decorator;

Ak ak=new Ak();
M4 m4 = new M4();

ak.Shoot();
m4.Shoot();

Buff buff = new Buff();
buff.SetComponet(ak);
buff.SetComponet(m4);

ak.Shoot();
m4.Shoot();