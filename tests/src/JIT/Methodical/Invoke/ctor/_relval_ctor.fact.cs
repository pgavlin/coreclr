using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_ctor__relval_ctor__relval_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__relval_ctor__relval_ctor_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_relval_ctor\\_relval_ctor.cmd");
        }
    }
}
