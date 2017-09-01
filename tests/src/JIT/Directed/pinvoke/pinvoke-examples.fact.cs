using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _pinvoke_pinvoke_examples_pinvoke_examples_
    {
        [OuterLoop]
        [Fact]
        public void _pinvoke_pinvoke_examples_pinvoke_examples_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\pinvoke-examples\\pinvoke-examples.cmd");
        }
    }
}
