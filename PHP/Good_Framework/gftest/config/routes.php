<?php

$cnf['*']['namespace']='Controllers';

$cnf['admin']['namespace'] = 'Test\Namespace';
$cnf['admin/user']['namespace'] = 'Test\Namespace1';


$cnf['administration']['namespace'] = 'Controllers\Admin';
$cnf['administration']['controllers']['new']['to'] = 'create';
$cnf['administration']['controllers']['new']['methods']['new']= '_new';

return $cnf;