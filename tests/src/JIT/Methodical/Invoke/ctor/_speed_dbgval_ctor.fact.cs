using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_ctor__speed_dbgval_ctor__speed_dbgval_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__speed_dbgval_ctor__speed_dbgval_ctor_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_speed_dbgval_ctor\\_speed_dbgval_ctor.cmd");
        }
    }
}
