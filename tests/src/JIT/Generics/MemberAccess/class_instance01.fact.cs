using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _MemberAccess_class_instance01_class_instance01_
    {
        [OuterLoop]
        [Fact]
        public void _MemberAccess_class_instance01_class_instance01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\MemberAccess\\class_instance01\\class_instance01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
