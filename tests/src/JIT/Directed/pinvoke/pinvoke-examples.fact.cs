using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinvoke_pinvoke_examples_pinvoke_examples_
    {
        [OuterLoop]
        [Fact]
        public void _pinvoke_pinvoke_examples_pinvoke_examples_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\pinvoke-examples\\pinvoke-examples.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
