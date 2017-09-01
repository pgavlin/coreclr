using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _TypedReference_TypedReference_TypedReference_
    {
        [OuterLoop]
        [Fact]
        public void _TypedReference_TypedReference_TypedReference_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\TypedReference\\TypedReference\\TypedReference.cmd");
        }
    }
}
