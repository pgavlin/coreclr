using CoreclrTestLib;
using Xunit;

namespace baseservices_regression
{
    class _v1_threads_functional_threadpool_cs_threadpoolnullchecks_CS_ThreadPoolNullChecks_CS_ThreadPoolNullChecks_
    {
        [OuterLoop]
        [Fact]
        public void _v1_threads_functional_threadpool_cs_threadpoolnullchecks_CS_ThreadPoolNullChecks_CS_ThreadPoolNullChecks_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\regression\\v1\\threads\\functional\\threadpool\\cs_threadpoolnullchecks\\CS_ThreadPoolNullChecks\\CS_ThreadPoolNullChecks.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
