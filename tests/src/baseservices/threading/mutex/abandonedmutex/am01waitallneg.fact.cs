using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_abandonedmutex_am01waitallneg_am01waitallneg_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am01waitallneg_am01waitallneg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am01waitallneg\\am01waitallneg.cmd");
        }
    }
}
