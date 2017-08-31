using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__Simpleb207621__Simpleb207621_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__Simpleb207621__Simpleb207621_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_Simpleb207621\\_Simpleb207621.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
