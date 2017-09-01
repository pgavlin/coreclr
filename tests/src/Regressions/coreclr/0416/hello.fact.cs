using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0416_hello_hello_
    {
        [OuterLoop]
        [Fact]
        public void _0416_hello_hello_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0416\\hello\\hello.cmd");
        }
    }
}
