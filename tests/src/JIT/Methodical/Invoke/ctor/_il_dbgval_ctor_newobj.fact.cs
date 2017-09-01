using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_ctor__il_dbgval_ctor_newobj__il_dbgval_ctor_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__il_dbgval_ctor_newobj__il_dbgval_ctor_newobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_il_dbgval_ctor_newobj\\_il_dbgval_ctor_newobj.cmd");
        }
    }
}
