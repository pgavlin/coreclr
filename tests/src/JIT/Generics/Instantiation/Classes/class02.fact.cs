using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Instantiation_Classes_class02_class02_
    {
        [OuterLoop]
        [Fact]
        public void _Instantiation_Classes_class02_class02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Instantiation\\Classes\\class02\\class02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
