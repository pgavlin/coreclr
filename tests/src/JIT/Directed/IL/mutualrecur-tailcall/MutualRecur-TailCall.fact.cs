using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _IL_mutualrecur_tailcall_MutualRecur_TailCall_MutualRecur_TailCall_
    {
        [Fact]
        public void _IL_mutualrecur_tailcall_MutualRecur_TailCall_MutualRecur_TailCall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\IL\\mutualrecur-tailcall\\MutualRecur-TailCall\\MutualRecur-TailCall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
