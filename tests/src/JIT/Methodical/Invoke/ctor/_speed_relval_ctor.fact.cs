using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_ctor__speed_relval_ctor__speed_relval_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__speed_relval_ctor__speed_relval_ctor_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_speed_relval_ctor\\_speed_relval_ctor.cmd");
        }
    }
}
