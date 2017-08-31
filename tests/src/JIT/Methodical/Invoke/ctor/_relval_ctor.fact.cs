using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_ctor__relval_ctor__relval_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__relval_ctor__relval_ctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_relval_ctor\\_relval_ctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
