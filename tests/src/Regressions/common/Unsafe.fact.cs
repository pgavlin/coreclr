using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _Unsafe_Unsafe_
    {
        [Fact]
        public void _Unsafe_Unsafe_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\Unsafe\\Unsafe.cmd");
        }
    }
}
