using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_volatile_1_cpobj_cpobj_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_volatile_1_cpobj_cpobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\volatile\\1\\cpobj\\cpobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
