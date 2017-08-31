using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__Simpletest2__Simpletest2_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__Simpletest2__Simpletest2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_Simpletest2\\_Simpletest2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
