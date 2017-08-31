using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__Simpletest4__Simpletest4_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__Simpletest4__Simpletest4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_Simpletest4\\_Simpletest4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
