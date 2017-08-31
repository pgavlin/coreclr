using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_unaligned_2_ldobj_ldobj_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_ldobj_ldobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\ldobj\\ldobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
