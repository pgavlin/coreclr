using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _stringintern__Simpletest1__Simpletest1_
    {
        [OuterLoop]
        [Fact]
        public void _stringintern__Simpletest1__Simpletest1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\stringintern\\_Simpletest1\\_Simpletest1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
