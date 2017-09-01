using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _pow3_pow3_
    {
        [Fact]
        public void _pow3_pow3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\pow3\\pow3.cmd");
        }
    }
}
